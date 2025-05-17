using System.Net;
using Demo.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestSharp;

namespace Demo.Services
{
    public interface IWebhookManager
    {
        Task ProcessShopifyOrderTigger(Models.ServiceBus.Order.DataModel data);
        Task ProcessShopifyRefundOrder(Models.ServiceBus.RefundOrder.DataModel data);
        Task ProcessShopifyProductTrigger(Models.ServiceBus.Product.DataModel data);
    }

    public class WebhookManager : IWebhookManager
    {
        private readonly string _baseUrl = "##PLACE YOUR STORE BASE URL HERE##";
        private readonly string _shopifyApiToken = "##PLACE YOUR SHOPIFY API TOKEN HERE##";


        private async Task<InventoryItemModel> FetchInventoryItems(string inventoryItemids, string? store)
        {
            string token = _shopifyApiToken;
            string baseUrl = _baseUrl;
            RestClient client = new RestClient(baseUrl);
            try
            {
                RestRequest request =
                    new RestRequest($"/admin/api/2024-04/inventory_items.json?ids={inventoryItemids}");
                request.AddHeader("X-Shopify-Access-Token", token);

                var response = await client.ExecuteAsync(request);

                if (response == null || response.StatusCode != HttpStatusCode.OK ||
                    string.IsNullOrWhiteSpace(response.Content))
                {
                    return null;
                }

                InventoryItemModel? result = JsonConvert.DeserializeObject<InventoryItemModel>(response.Content,
                    new JsonSerializerSettings()
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        ContractResolver = new DefaultContractResolver()
                        {
                            NamingStrategy = new SnakeCaseNamingStrategy()
                        }
                    });
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                try
                {
                    client.Dispose();
                }
                catch
                {
                }
            }
        }
        public async Task ProcessShopifyOrderTigger(Models.ServiceBus.Order.DataModel data)
        {
            // 1. Initial Data Processing
            // - Extract data body and store domain
            // - Deserialize JSON to OrderViewModel using snake case naming strategy
            // - Log order processing start
            // - Early return if deserialization fails

            // 2. Customer Processing
            // - Check if customer exists in database
            // - If not exists:
            //   - Create new customer record with basic info (ID, email, name, etc.)
            //   - Include default address details if available
            //   - Handle potential duplicate key exceptions
            // - Log any customer processing errors

            // 3. Order Processing
            // - Check if order exists by ID
            // - If not exists:
            //   - Create new order with full details (financial status, addresses, etc.)
            //   - Include all monetary amounts and customer references
            // - If exists:
            //   - Update all order fields with latest information
            // - Handle potential duplicate key exceptions

            // 4. Order Line Items Processing
            // - Process each line item in the order
            // - For each item:
            //   - Create/update basic line item details
            //   - Process associated tax lines
            //   - Process discount allocations
            // - Batch insert/update operations for performance
            // - Handle error logging for line items processing

            // 5. Order Discount Codes Processing
            // - Process all discount codes associated with order
            // - Skip empty/invalid codes
            // - Only insert new unique codes
            // - Handle error logging

            // 6. Order Tax Lines Processing
            // - Process all tax lines for the order
            // - Skip empty/invalid tax lines
            // - Only insert new unique tax entries
            // - Handle error logging

            // 7. Shipping Lines Processing
            // - Process all shipping lines
            // - For each shipping line:
            //   - Create/update shipping line details
            //   - Process associated tax lines
            //   - Process discount allocations
            // - Handle batch operations and duplicates
            // - Handle error logging

            // 8. Refunds Processing
            // - If refunds exist, process them
            // - Delegate to separate refund processing method
            // - Handle error logging

            // 9. Error Handling
            // - Implement comprehensive error logging
            // - Log specific error details for each processing step
            // - Maintain error context for debugging
            // - Handle duplicate key violations appropriately
        }

        private async Task ProcessOrderRefunds(long orderId, List<Models.ServiceBus.RefundOrder.DataModel> refunds)
        {
            // 1. Fetch existing order refunds and initialize tracking collections
            // - Get existing order refunds for the given orderId
            // - Initialize collections to track:
            //   * New order refunds to be inserted
            //   * New and updated refund line items
            //   * New refund order adjustments

            // 2. If existing order refunds found, fetch related data
            // - Get existing refund line items for the refund IDs
            // - Get existing refund order adjustments for the refund IDs

            // 3. Process each refund in the input list:
            //    a. Handle Order Refund
            //       - Check if refund already exists
            //       - If not, create new OrderRefunds entity with:
            //         * Refund ID, Order ID, ProcessedAt, CreatedAt

            //    b. Process Refund Line Items
            //       - For each line item in the refund:
            //         * Check if it exists
            //         * If new: Create OrderRefundLineItems with line item details
            //           (ID, RefundID, LineItemID, taxes, quantities, prices)
            //         * If existing: Update with current values
            //         * Track for insert/update accordingly

            //    c. Process Order Adjustments
            //       - For each adjustment in the refund:
            //         * Check if already processed
            //         * If not, create new RefundsOrderAdjustments entity
            //           with adjustment details (IDs, kind, amounts)

            // 4. Perform database operations with error handling:
            //    a. Insert new order refunds
            //       - Handle potential duplicate key errors from concurrent requests

            //    b. Handle refund line items
            //       - Insert new line items (handle duplicates)
            //       - Update existing line items

            //    c. Insert new refund order adjustments
            //       - Handle potential duplicate key errors

            // Note: All database operations should handle concurrent request scenarios
            // by properly catching and handling duplicate key exceptions
        }

        public async Task ProcessShopifyRefundOrder(Models.ServiceBus.RefundOrder.DataModel data)
        {
            try
            {
                // Deserialize the data.Data string into a Refund object
                // - Use JsonConvert.DeserializeObject<Refund>
                // - Configure JSON settings to use snake case naming strategy
                // - Handle null deserialization result

                // If deserialization returns null
                // - Log error about empty/invalid refund trigger body
                // - Return from method

                // Log the successful receipt of refund order
                // - Include refund ID and order ID in log message

                // Create a list containing single refund order

                // Process the refund order
                // - Call ProcessOrderRefunds with order ID and refunds list
            }
            catch (Exception ex)
            {
                // Log any errors that occur during processing
                // - Include webhook processing error message
                // - Include original data and exception details
            }
        }

        public async Task ProcessShopifyProductTrigger(Models.ServiceBus.Product.DataModel data)
        {
            // 1. Validate input data
            // - Check if data is null and return if so
            // - Extract body from data.Data
            // - Extract store from data.Domain

            // 2. Deserialize product data
            // - Deserialize body to Product object using snake case naming strategy
            // - If deserialization fails, log error and return
            // - Log successful trigger with product ID

            // 3. Handle existing product check and updates
            // - Find existing product by ID
            // - If product exists:
            //   - Track status changes in ProductsTracking table
            //   - Track status and vendor changes in ProductsTrackingHistory
            //   - Update existing product fields (Title, ProductType, Vendor, Status, UpdatedAt)
            // - If product doesn't exist:
            //   - Create new Products record with basic fields
            //   - Insert into database

            // 4. Process product variants
            // - Return if no variants exist
            // - Get distinct variant IDs and inventory item IDs
            // - Fetch inventory items data for cost information
            // - Get existing product variants from database
            // - For each variant in incoming data:
            //   - Skip if already processed
            //   - Check if variant exists in database
            //   - If variant doesn't exist:
            //     - Create new ProductsVariants with all fields
            //     - Add to insertion list
            //   - If variant exists:
            //     - Track price and compare-at-price changes in history
            //     - Update all variant fields
            //     - Add to update list

            // 5. Persist variant changes
            // - Bulk insert new variants if any
            // - Bulk update existing variants if any
            // - Insert tracking history records with UK timezone timestamp

            // 6. Error handling
            // - Catch all exceptions
            // - Log errors with original request body
        }
    }
}