using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;

namespace Demo.Filters
{
    public class WebhookAuthFilter : IAsyncAuthorizationFilter
    {
        private readonly IConfiguration _config;
        public WebhookAuthFilter(IConfiguration config)
        {
            _config = config;
        }

        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            try
            {
                var originalBody = context.HttpContext.Request.Body;
                using var memoryStream = new MemoryStream();
                await originalBody.CopyToAsync(memoryStream);

                memoryStream.Position = 0;
                context.HttpContext.Request.Body = memoryStream;

                string shopifySecretKey = _config["Shopify:Client_Secret"];
                if (string.IsNullOrEmpty(shopifySecretKey))
                {
                    context.Result = GetContentResult(500, "Error retrieving store configuration.");
                    return;
                }

                var requestHeaders = context.HttpContext.Request.Headers;
                bool isValidRequest = await IsAuthenticWebhook(
                    requestHeaders,
                    memoryStream,
                    shopifySecretKey
                );

                if (!isValidRequest)
                {
                    context.Result = GetContentResult(403, "Access forbidden, request is not coming from Shopify.");
                }
                else
                {
                    memoryStream.Position = 0;
                    context.HttpContext.Request.Body = memoryStream;
                }
            }
            catch (Exception ex)
            {
                context.Result = GetContentResult(500, $"Server error authenticating webhook request. {ex.Message}");
            }
        }

        private async Task<bool> IsAuthenticWebhook(
            IHeaderDictionary requestHeaders,
            MemoryStream requestBodyStream,
            string shopifySecretKey)
        {
            requestBodyStream.Position = 0;
            using var reader = new StreamReader(requestBodyStream, leaveOpen: true);
            var requestBody = await reader.ReadToEndAsync();

            requestBodyStream.Position = 0;

            if (!requestHeaders.TryGetValue("X-Shopify-Hmac-SHA256", out var hmacHeaderValues) ||
                hmacHeaderValues.Count == 0)
            {
                return false;
            }

            string hmacHeader = hmacHeaderValues.First();

            using HMACSHA256 hmac = new HMACSHA256(Encoding.UTF8.GetBytes(shopifySecretKey));
            string computedHash = Convert.ToBase64String(hmac.ComputeHash(Encoding.UTF8.GetBytes(requestBody)));

            return computedHash.Equals(hmacHeader, StringComparison.OrdinalIgnoreCase);
        }

        private static ContentResult GetContentResult(int code, string message)
        {
            return new ContentResult
            {
                StatusCode = code,
                Content = System.Text.Json.JsonSerializer.Serialize(new
                {
                    code,
                    error = message
                }),
                ContentType = "application/json"
            };
        }
    }
}