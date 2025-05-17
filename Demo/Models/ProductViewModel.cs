using System.Text.Json.Serialization;

namespace Demo.Models
{
    public class ProductViewModel
    {
        [JsonPropertyName("products")]
        public List<Product> Products { get; set; }
    }
    public class Product
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("product_type")]
        public string? ProductType { get; set; }

        [JsonPropertyName("vendor")]
        public string? Vendor { get; set; }

        [JsonPropertyName("status")]
        public string? status { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("variants")]
        public List<Variant> Variants { get; set; }
    }
    public class Variant
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("product_id")]
        public long ProductId { get; set; }
        [JsonPropertyName("sku")]
        public string? Sku { get; set; }
        [JsonPropertyName("title")]
        public string? Title { get; set; }
        [JsonPropertyName("price")]
        public decimal? Price { get; set; }
        [JsonPropertyName("position")]
        public long? Position { get; set; }
        [JsonPropertyName("compare_at_price")]
        public string? CompareAtPrice { get; set; }
        [JsonPropertyName("option1")]
        public string? Option1 { get; set; }
        [JsonPropertyName("option2")]
        public string? Option2 { get; set; }
        [JsonPropertyName("option3")]
        public string? Option3 { get; set; }
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }
        [JsonPropertyName("taxable")]
        public bool Taxable { get; set; }
        [JsonPropertyName("barcode")]
        public string? Barcode { get; set; }
        [JsonPropertyName("grams")]
        public long? Grams { get; set; }
        [JsonPropertyName("weight")]
        public decimal? Weight { get; set; }
        [JsonPropertyName("weight_unit")]
        public string? WeightUnit { get; set; }
        [JsonPropertyName("inventory_item_id")]
        public long? InventoryItemId { get; set; }
        [JsonPropertyName("admin_graphql_api_id")]
        public string? AdminGraphqlApiId { get; set; }
    }

    public class InventoryItemModel
    {
        [JsonPropertyName("inventory_items")]
        public List<InventoryItem> InventoryItems { get; set;}
    }

    public class InventoryItem
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("cost")]
        public decimal? Cost { get; set; }

    }
}
