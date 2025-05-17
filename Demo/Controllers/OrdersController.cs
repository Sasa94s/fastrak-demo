using Demo.Data;
using Demo.Data.Models;
using Demo.Filters;
using Demo.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly DemoDbContext _db;

        public OrdersController(DemoDbContext db)
        {
            _db = db;
        }

        [HttpPost]
        [ServiceFilter(typeof(WebhookAuthFilter))]
        public async Task<IActionResult> Post()
        {
            // 1) Read raw request body
            using var reader = new StreamReader(Request.Body);
            var requestText = await reader.ReadToEndAsync();

            // 2) Deserialize to OrderViewModel
            OrderViewModel order;
            try
            {
                order = JsonConvert.DeserializeObject<OrderViewModel>(requestText);
            }
            catch
            {
                return BadRequest("Invalid JSON payload.");
            }

            // 3) Validate required fields
            if (order is null || order.Customer is null)
            {
                return BadRequest("Missing required order/customer data.");
            }

            // 4) Save to DB
            var entity = new OrderEntity
            {
                ShopifyOrderId = order.Id,
                OrderName = order.Name ?? $"Order_{order.Id}",
                RawJson = requestText
            };

            _db.Orders.Add(entity);
            await _db.SaveChangesAsync();

            // 5) Return success
            return Ok(new
            {
                Message = "Order processed successfully.",
                ShopifyOrderId = order.Id,
                LocalId = entity.Id
            });
        }
    }
}