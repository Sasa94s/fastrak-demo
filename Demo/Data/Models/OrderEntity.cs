namespace Demo.Data.Models;


public class OrderEntity
{
    public int Id { get; set; }

    /// <summary>
    /// Shopify's Order ID.
    /// </summary>
    public long ShopifyOrderId { get; set; }

    /// <summary>
    /// Shopify order name, e.g. "#1001".
    /// </summary>
    public string OrderName { get; set; }

    /// <summary>
    /// JSON representation of the entire Shopify order payload (for debugging / record-keeping).
    /// </summary>
    public string RawJson { get; set; }

    /// <summary>
    /// DateTime of insertion.
    /// </summary>
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}