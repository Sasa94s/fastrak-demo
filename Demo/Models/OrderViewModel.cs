using System.Text.Json.Serialization;

namespace Demo.Models
{
    #region DISCOUNT MODELS
    public class DiscountAllocation
    {
        [JsonPropertyName("amount")]
        public string? Amount { get; set; }
        [JsonPropertyName("amount_set")]
        public GenericMoneySet? AmountSet { get; set; }
        [JsonPropertyName("discount_application_index")]
        public long DiscountApplicationIndex { get; set; }
    }
    public class DiscountApplication
    {
        [JsonPropertyName("target_type")]
        public string? TargetType { get; set; }
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        [JsonPropertyName("value")]
        public string? Value { get; set; }
        [JsonPropertyName("value_type")]
        public string? ValueType { get; set; }
        [JsonPropertyName("allocation_method")]
        public string? AllocationMethod { get; set; }
        [JsonPropertyName("target_selection")]
        public string? TargetSelection { get; set; }
        [JsonPropertyName("code")]
        public string? Code { get; set; }
    }
    public class DiscountCode
    {
        [JsonPropertyName("code")]
        public string? Code { get; set; }
        [JsonPropertyName("amount")]
        public string? Amount { get; set; }
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }
    #endregion

    public class LineItem
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("admin_graphql_api_id")]
        public string AdminGraphqlApiId { get; set; }
        [JsonPropertyName("current_quantity")]
        public int CurrentQuantity { get; set; }
        [JsonPropertyName("fulfillable_quantity")]
        public int FulfillableQuantity { get; set; }
        [JsonPropertyName("fulfillment_service")]
        public string FulfillmentService { get; set; }
        [JsonPropertyName("fulfillment_status")]
        public string FulfillmentStatus { get; set; }
        [JsonPropertyName("gift_card")]
        public bool GiftCard { get; set; }
        [JsonPropertyName("grams")]
        public decimal Grams { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("pre_tax_price")]
        public decimal? PreTaxPrice { get; set; }
        [JsonPropertyName("pre_tax_price_set")]
        public GenericMoneySet? PreTaxPriceSet { get; set; }
        [JsonPropertyName("price")]
        public decimal Price { get; set; }
        [JsonPropertyName("price_set")]
        public GenericMoneySet PriceSet { get; set; }
        [JsonPropertyName("product_exists")]
        public bool ProductExists { get; set; }
        [JsonPropertyName("product_id")]
        public long? ProductId { get; set; }
        [JsonPropertyName("properties")]
        public List<NameValueAttribute> Properties { get; set; }
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }
        [JsonPropertyName("requires_shipping")]
        public bool RequiresShipping { get; set; }
        [JsonPropertyName("sku")]
        public string Sku { get; set; }
        [JsonPropertyName("taxable")]
        public bool Taxable { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("total_discount")]
        public decimal TotalDiscount { get; set; }
        [JsonPropertyName("total_discount_set")]
        public GenericMoneySet TotalDiscountSet { get; set; }
        [JsonPropertyName("variant_id")]
        public long? VariantId { get; set; }
        [JsonPropertyName("variant_inventory_management")]
        public string? VariantInventoryManagement { get; set; }
        [JsonPropertyName("variant_title")]
        public string VariantTitle { get; set; }
        [JsonPropertyName("vendor")]
        public string? Vendor { get; set; }
        [JsonPropertyName("tax_lines")]
        public List<TaxLine> TaxLines { get; set; }
        [JsonPropertyName("discount_allocations")]
        public List<DiscountAllocation> DiscountAllocations { get; set; }
    }

    public class OrderViewModel
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("total_price")]
        public decimal TotalPrice { get; set; }
        [JsonPropertyName("company")]
        public Company? Company { get; set; }
        [JsonPropertyName("line_items")]
        public List<LineItem> LineItems { get; set; }
        [JsonPropertyName("admin_graphql_api_id")]
        public string? AdminGraphqlApiId { get; set; }
        [JsonPropertyName("app_id")]
        public int AppId { get; set; }
        [JsonPropertyName("browser_ip")]
        public string? BrowserIp { get; set; }
        [JsonPropertyName("buyer_accepts_marketing")]
        public bool BuyerAcceptsMarketing { get; set; }
        [JsonPropertyName("cancel_reason")]
        public string? CancelReason { get; set; }
        [JsonPropertyName("cancelled_at")]
        public DateTime? CancelledAt { get; set; }
        [JsonPropertyName("cart_token")]
        public string? CartToken { get; set; }
        [JsonPropertyName("checkout_id")]
        public long? CheckoutId { get; set; }
        [JsonPropertyName("checkout_token")]
        public string CheckoutToken { get; set; }
        [JsonPropertyName("client_details")]
        public ClientDetails ClientDetails { get; set; }
        [JsonPropertyName("closed_at")]
        public DateTime? ClosedAt { get; set; }
        [JsonPropertyName("confirmation_number")]
        public string ConfirmationNumber { get; set; }
        [JsonPropertyName("confirmed")]
        public bool Confirmed { get; set; }
        [JsonPropertyName("contact_email")]
        public string ContactEmail { get; set; }
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonPropertyName("currency")]
        public string Currency { get; set; }
        [JsonPropertyName("current_subtotal_price")]
        public decimal CurrentSubtotalPrice { get; set; }
        [JsonPropertyName("current_subtotal_price_set")]
        public GenericMoneySet CurrentSubtotalPriceSet { get; set; }
        [JsonPropertyName("current_total_additional_fees_set")]
        public GenericMoneySet? CurrentTotalAdditionalFeesSet { get; set; }
        [JsonPropertyName("current_total_discounts")]
        public decimal CurrentTotalDiscounts { get; set; }
        [JsonPropertyName("current_total_discounts_set")]
        public GenericMoneySet CurrentTotalDiscountsSet { get; set; }
        [JsonPropertyName("current_total_duties_set")]
        public GenericMoneySet? CurrentTotalDutiesSet { get; set; }
        [JsonPropertyName("current_total_price")]
        public decimal CurrentTotalPrice { get; set; }
        [JsonPropertyName("current_total_price_set")]
        public GenericMoneySet CurrentTotalPriceSet { get; set; }
        [JsonPropertyName("current_total_tax")]
        public decimal CurrentTotalTax { get; set; }
        [JsonPropertyName("current_total_tax_set")]
        public GenericMoneySet CurrentTotalTaxSet { get; set; }
        [JsonPropertyName("customer_locale")]
        public string CustomerLocale { get; set; }
        [JsonPropertyName("device_id")]
        public string? DeviceId { get; set; }
        [JsonPropertyName("discount_codes")]
        public List<DiscountCode> DiscountCodes { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("estimated_taxes")]
        public bool EstimatedTaxes { get; set; }
        [JsonPropertyName("financial_status")]
        public string FinancialStatus { get; set; }
        [JsonPropertyName("fulfillment_status")]
        public string? FulfillmentStatus { get; set; }
        [JsonPropertyName("landing_site")]
        public string? LandingSite { get; set; }
        [JsonPropertyName("landing_site_ref")]
        public string? LandingSiteRef { get; set; }
        [JsonPropertyName("location_id")]
        public string? LocationId { get; set; }
        [JsonPropertyName("merchant_of_record_app_id")]
        public string? MerchantOfRecordAppId { get; set; }
        [JsonPropertyName("note")]
        public string? Note { get; set; }
        [JsonPropertyName("note_attributes")]
        public List<NameValueAttribute> NoteAttributes { get; set; }
        [JsonPropertyName("number")]
        public int Number { get; set; }
        [JsonPropertyName("order_number")]
        public int OrderNumber { get; set; }
        [JsonPropertyName("order_status_url")]
        public string OrderStatusUrl { get; set; }
        [JsonPropertyName("original_total_additional_fees_set")]
        public GenericMoneySet? OriginalTotalAdditionalFeesSet { get; set; }
        [JsonPropertyName("original_total_duties_set")]
        public GenericMoneySet? OriginalTotalDutiesSet { get; set; }
        [JsonPropertyName("payment_gateway_names")]
        public List<string> PaymentGatewayNames { get; set; }
        [JsonPropertyName("phone")]
        public string? Phone { get; set; }
        [JsonPropertyName("po_number")]
        public string? PoNumber { get; set; }
        [JsonPropertyName("presentment_currency")]
        public string PresentmentCurrency { get; set; }
        [JsonPropertyName("processed_at")]
        public DateTime ProcessedAt { get; set; }
        [JsonPropertyName("reference")]
        public string? Reference { get; set; }
        [JsonPropertyName("referring_site")]
        public string? ReferringSite { get; set; }
        [JsonPropertyName("source_identifier")]
        public string? SourceIdentifier { get; set; }
        [JsonPropertyName("source_name")]
        public string SourceName { get; set; }
        [JsonPropertyName("source_url")]
        public string? SourceUrl { get; set; }
        [JsonPropertyName("subtotal_price")]
        public decimal SubtotalPrice { get; set; }
        [JsonPropertyName("subtotal_price_set")]
        public GenericMoneySet SubtotalPriceSet { get; set; }
        [JsonPropertyName("tags")]
        public string? Tags { get; set; }
        [JsonPropertyName("tax_exempt")]
        public bool TaxExempt { get; set; }
        [JsonPropertyName("tax_lines")]
        public List<TaxLine> TaxLines { get; set; }
        [JsonPropertyName("taxes_included")]
        public bool TaxesIncluded { get; set; }
        [JsonPropertyName("test")]
        public bool Test { get; set; }
        [JsonPropertyName("token")]
        public string Token { get; set; }
        [JsonPropertyName("total_discounts")]
        public decimal TotalDiscounts { get; set; }
        [JsonPropertyName("total_discounts_set")]
        public GenericMoneySet TotalDiscountsSet { get; set; }
        [JsonPropertyName("total_line_items_price")]
        public decimal TotalLineItemsPrice { get; set; }
        [JsonPropertyName("total_line_items_price_set")]
        public GenericMoneySet TotalLineItemsPriceSet { get; set; }
        [JsonPropertyName("total_outstanding")]
        public decimal TotalOutstanding { get; set; }
        [JsonPropertyName("total_price_set")]
        public GenericMoneySet TotalPriceSet { get; set; }
        [JsonPropertyName("total_shipping_price_set")]
        public GenericMoneySet TotalShippingPriceSet { get; set; }
        [JsonPropertyName("total_tax")]
        public decimal TotalTax { get; set; }
        [JsonPropertyName("total_tax_set")]
        public GenericMoneySet TotalTaxSet { get; set; }
        [JsonPropertyName("total_tip_received")]
        public decimal TotalTipReceived { get; set; }
        [JsonPropertyName("total_weight")]
        public int TotalWeight { get; set; }
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }
        [JsonPropertyName("user_id")]
        public long? UserId { get; set; }
        [JsonPropertyName("billing_address")]
        public BillingAddress BillingAddress { get; set; }
        [JsonPropertyName("customer")]
        public Customer Customer { get; set; }
        [JsonPropertyName("discount_applications")]
        public List<DiscountApplication> DiscountApplications { get; set; }
        [JsonPropertyName("fulfillments")]
        public List<Fulfillment> Fulfillments { get; set; }
        [JsonPropertyName("refunds")]
        public List<Refund> Refunds { get; set; }
        [JsonPropertyName("shipping_address")]
        public ShippingAddress ShippingAddress { get; set; }
        [JsonPropertyName("shipping_lines")]
        public List<ShippingLine>? ShippingLines { get; set; }
    }
    public class ShippingAddress
    {
        [JsonPropertyName("first_name")]
        public string? FirstName { get; set; }
        [JsonPropertyName("address1")]
        public string? Address1 { get; set; }
        [JsonPropertyName("phone")]
        public string? Phone { get; set; }
        [JsonPropertyName("city")]
        public string? City { get; set; }
        [JsonPropertyName("zip")]
        public string? Zip { get; set; }
        [JsonPropertyName("province")]
        public string? Province { get; set; }
        [JsonPropertyName("country")]
        public string? Country { get; set; }
        [JsonPropertyName("last_name")]
        public string? LastName { get; set; }
        [JsonPropertyName("address2")]
        public string? Address2 { get; set; }
        [JsonPropertyName("company")]
        public string? Company { get; set; }
        [JsonPropertyName("latitude")]
        public double? Latitude { get; set; }
        [JsonPropertyName("longitude")]
        public double? Longitude { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("country_code")]
        public string? CountryCode { get; set; }
        [JsonPropertyName("province_code")]
        public string? ProvinceCode { get; set; }
    }
    public class Company
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("location_id")]
        public int LocationId { get; set; }
    }
    public class ShippingLine
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("carrier_identifier")]
        public string? CarrierIdentifier { get; set; }
        [JsonPropertyName("code")]
        public string? Code { get; set; }
        [JsonPropertyName("discounted_price")]
        public string? DiscountedPrice { get; set; }
        [JsonPropertyName("discounted_price_set")]
        public GenericMoneySet? DiscountedPriceSet { get; set; }
        [JsonPropertyName("phone")]
        public string? Phone { get; set; }
        [JsonPropertyName("price")]
        public string? Price { get; set; }
        [JsonPropertyName("price_set")]
        public GenericMoneySet? PriceSet { get; set; }
        [JsonPropertyName("requested_fulfillment_service_id")]
        public string? RequestedFulfillmentServiceId { get; set; }
        [JsonPropertyName("source")]
        public string? Source { get; set; }
        [JsonPropertyName("title")]
        public string? Title { get; set; }
        [JsonPropertyName("tax_lines")]
        public List<TaxLine> TaxLines { get; set; }
        [JsonPropertyName("discount_allocations")]
        public List<DiscountAllocation> DiscountAllocations { get; set; }
    }
    public class Refund
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("admin_graphql_api_id")]
        public string? AdminGraphqlApiId { get; set; }
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonPropertyName("note")]
        public string? Note { get; set; }
        [JsonPropertyName("order_id")]
        public long OrderId { get; set; }
        [JsonPropertyName("processed_at")]
        public DateTime ProcessedAt { get; set; }
        [JsonPropertyName("restock")]
        public bool Restock { get; set; }
        [JsonPropertyName("total_additional_fees_set")]
        public GenericMoneySet? TotalAdditionalFeesSet { get; set; }
        [JsonPropertyName("total_duties_set")]
        public GenericMoneySet? TotalDutiesSet { get; set; }
        [JsonPropertyName("user_id")]
        public long? UserId { get; set; }
        [JsonPropertyName("transactions")]
        public List<Transaction> Transactions { get; set; }
        [JsonPropertyName("refund_line_items")]
        public List<RefundLineItem> RefundLineItems { get; set; }
        [JsonPropertyName("additional_fees")]
        public List<GenericMoneySet> AdditionalFees { get; set; }
        [JsonPropertyName("order_adjustments")]
        public List<OrderAdjustments>? OrderAdjustments { get; set; }
    }
    public class OrderAdjustments
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("order_id")]
        public long OrderId { get; set; }
        [JsonPropertyName("refund_id")]
        public long RefundId { get; set; }
        [JsonPropertyName("amount")]
        public decimal Amount { get; set; }
        [JsonPropertyName("tax_amount")]
        public decimal TaxAmount { get; set; }
        [JsonPropertyName("kind")]
        public string? Kind { get; set; }
    }
    public class RefundLineItem
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("line_item_id")]
        public long LineItemId { get; set; }
        [JsonPropertyName("location_id")]
        public long? LocationId { get; set; }
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }
        [JsonPropertyName("restock_type")]
        public string? RestockType { get; set; }
        [JsonPropertyName("subtotal")]
        public decimal Subtotal { get; set; }
        [JsonPropertyName("subtotal_set")]
        public SubtotalSet SubtotalSet { get; set; }
        [JsonPropertyName("total_tax")]
        public decimal TotalTax { get; set; }
        [JsonPropertyName("total_tax_set")]
        public GenericMoneySet? TotalTaxSet { get; set; }
        [JsonPropertyName("line_item")]
        public LineItem LineItem { get; set; }
    }
    public class NameValueAttribute
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("value")]
        public string? Value { get; set; }
    }
    public class Receipt
    {
        [JsonPropertyName("testcase")]
        public bool TestCase { get; set; }
        [JsonPropertyName("authorization")]
        public string? Authorization { get; set; }
    }
    public class GenericMoneySet
    {
        [JsonPropertyName("shop_money")]
        public ShopPresentmentMoney ShopMoney { get; set; }
        [JsonPropertyName("presentment_money")]
        public ShopPresentmentMoney PresentmentMoney { get; set; }
    }

    public class ShopPresentmentMoney
    {
        [JsonPropertyName("amount")]
        public string? Amount { get; set; }
        [JsonPropertyName("currency_code")]
        public string? CurrencyCode { get; set; }
    }
    public class SubtotalSet
    {
        [JsonPropertyName("amount")]
        public string? Amount { get; set; }
        [JsonPropertyName("currency_code")]
        public string? CurrencyCode { get; set; }
    }

    public class TaxLine
    {
        [JsonPropertyName("channel_liable")]
        public bool? ChannelLiable { get; set; }
        [JsonPropertyName("price")]
        public decimal? Price { get; set; }
        [JsonPropertyName("price_set")]
        public GenericMoneySet? PriceSet { get; set; }
        [JsonPropertyName("rate")]
        public decimal? Rate { get; set; }
        [JsonPropertyName("title")]
        public string? Title { get; set; }
    }
    public class BillingAddress
    {
        [JsonPropertyName("first_name")]
        public string? FirstName { get; set; }
        [JsonPropertyName("address1")]
        public string? Address1 { get; set; }
        [JsonPropertyName("phone")]
        public string? Phone { get; set; }
        [JsonPropertyName("city")]
        public string? City { get; set; }
        [JsonPropertyName("zip")]
        public string? Zip { get; set; }
        [JsonPropertyName("province")]
        public string? Province { get; set; }
        [JsonPropertyName("country")]
        public string? Country { get; set; }
        [JsonPropertyName("last_name")]
        public string? LastName { get; set; }
        [JsonPropertyName("address2")]
        public string? Address2 { get; set; }
        [JsonPropertyName("company")]
        public string? Company { get; set; }
        [JsonPropertyName("latitude")]
        public double? Latitude { get; set; }
        [JsonPropertyName("longitude")]
        public double? Longitude { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("country_code")]
        public string? CountryCode { get; set; }
        [JsonPropertyName("province_code")]
        public string? ProvinceCode { get; set; }
    }
    public class OriginAddress
    {
    }
    public class ClientDetails
    {
        [JsonPropertyName("accept_language")]
        public string? AcceptLanguage { get; set; }
        [JsonPropertyName("browser_height")]
        public decimal? BrowserHeight { get; set; }
        [JsonPropertyName("browser_ip")]
        public string? BrowserIp { get; set; }
        [JsonPropertyName("browser_width")]
        public decimal? BrowserWidth { get; set; }
        [JsonPropertyName("session_hash")]
        public string? SessionHash { get; set; }
        [JsonPropertyName("user_agent")]
        public string? UserAgent { get; set; }
    }
    public class Customer
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }
        [JsonPropertyName("first_name")]
        public string? FirstName { get; set; }
        [JsonPropertyName("last_name")]
        public string? LastName { get; set; }
        [JsonPropertyName("state")]
        public string? State { get; set; }
        [JsonPropertyName("note")]
        public string? Note { get; set; }
        [JsonPropertyName("verified_email")]
        public bool VerifiedEmail { get; set; }
        [JsonPropertyName("multipass_identifier")]
        public string? MultipassIdentifier { get; set; }
        [JsonPropertyName("tax_exempt")]
        public bool TaxExempt { get; set; }
        [JsonPropertyName("phone")]
        public string? Phone { get; set; }
        [JsonPropertyName("email_marketing_consent")]
        public ExternalMarketingConsent EmailMarketingConsent { get; set; }
        [JsonPropertyName("sms_marketing_consent")]
        public ExternalMarketingConsent SmsMarketingConsent { get; set; }
        [JsonPropertyName("tags")]
        public string? Tags { get; set; }
        [JsonPropertyName("currency")]
        public string? Currency { get; set; }
        [JsonPropertyName("tax_exemptions")]
        public List<object> TaxExemptions { get; set; }
        [JsonPropertyName("admin_graphql_api_id")]
        public string? AdminGraphqlApiId { get; set; }
        [JsonPropertyName("default_address")]
        public DefaultAddress DefaultAddress { get; set; }
    }
    public class ExternalMarketingConsent
    {
        [JsonPropertyName("state")]
        public string? State { get; set; }
        [JsonPropertyName("opt_in_level")]
        public string? OptInLevel { get; set; }
        [JsonPropertyName("consent_updated_at")]
        public DateTime? ConsentUpdatedAt { get; set; }
        [JsonPropertyName("consent_collected_from")]
        public string? ConsentCollectedFrom { get; set; }
    }
    public class DefaultAddress
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("customer_id")]
        public long CustomerId { get; set; }
        [JsonPropertyName("first_name")]
        public string? FirstName { get; set; }
        [JsonPropertyName("last_name")]
        public string? LastName { get; set; }
        [JsonPropertyName("company")]
        public string? Company { get; set; }
        [JsonPropertyName("address1")]
        public string? Address1 { get; set; }
        [JsonPropertyName("address2")]
        public string? Address2 { get; set; }
        [JsonPropertyName("city")]
        public string? City { get; set; }
        [JsonPropertyName("province")]
        public string? Province { get; set; }
        [JsonPropertyName("country")]
        public string? Country { get; set; }
        [JsonPropertyName("zip")]
        public string? Zip { get; set; }
        [JsonPropertyName("phone")]
        public string? Phone { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("province_code")]
        public string? ProvinceCode { get; set; }
        [JsonPropertyName("country_code")]
        public string? CountryCode { get; set; }
        [JsonPropertyName("country_name")]
        public string? CountryName { get; set; }
        [JsonPropertyName("default")]
        public bool Default { get; set; }
    }
    public class Fulfillment
    {
        [JsonPropertyName("id")]
        public long? id { get; set; }
        [JsonPropertyName("admin_graphql_api_id")]
        public string? AdminGraphqlApiId { get; set; }
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }
        [JsonPropertyName("location_id")]
        public long? LocationId { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("order_id")]
        public long? OrderId { get; set; }
        [JsonPropertyName("origin_address")]
        public OriginAddress? OriginAddress { get; set; }
        [JsonPropertyName("receipt")]
        public Receipt? Receipt { get; set; }
        [JsonPropertyName("service")]
        public string? Service { get; set; }
        [JsonPropertyName("shipment_status")]
        public string? ShipmentStatus { get; set; }
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        [JsonPropertyName("tracking_company")]
        public string? TrackingCompany { get; set; }
        [JsonPropertyName("tracking_number")]
        public string? TrackingNumber { get; set; }
        [JsonPropertyName("tracking_numbers")]
        public List<string>? TrackingNumbers { get; set; }
        [JsonPropertyName("tracking_url")]
        public string? TrackingUrl { get; set; }
        [JsonPropertyName("tracking_urls")]
        public List<string>? TrackingUrls { get; set; }
        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }
        [JsonPropertyName("line_items")]
        public List<LineItem>? LineItems { get; set; }
    }
    public class Transaction
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("admin_graphql_api_id")]
        public string? AdminGraphqlApiId { get; set; }
        [JsonPropertyName("amount")]
        public string? Amount { get; set; }
        [JsonPropertyName("authorization")]
        public string? Authorization { get; set; }
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonPropertyName("currency")]
        public string? Currency { get; set; }
        [JsonPropertyName("device_id")]
        public long? DeviceId { get; set; }
        [JsonPropertyName("error_code")]
        public string? ErrorCode { get; set; }
        [JsonPropertyName("gateway")]
        public string? Gateway { get; set; }
        [JsonPropertyName("kind")]
        public string? Kind { get; set; }
        [JsonPropertyName("location_id")]
        public long? LocationId { get; set; }
        [JsonPropertyName("message")]
        public string? Message { get; set; }
        [JsonPropertyName("order_id")]
        public long OrderId { get; set; }
        [JsonPropertyName("parent_id")]
        public long ParentId { get; set; }
        [JsonPropertyName("payment_id")]
        public string? PaymentId { get; set; }
        [JsonPropertyName("processed_at")]
        public DateTime ProcessedAt { get; set; }
        [JsonPropertyName("receipt")]
        public Receipt Receipt { get; set; }
        [JsonPropertyName("source_name")]
        public string? SurceName { get; set; }
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        [JsonPropertyName("test")]
        public bool Test { get; set; }
        [JsonPropertyName("user_id")]
        public long? UserId { get; set; }
    }
    public class PaymentInfo
    {
        public string TransactionID { get; set; }
        public object ParentTransactionID { get; set; }
        public object ReceiptID { get; set; }
        public string TransactionType { get; set; }
        public string PaymentType { get; set; }
        public DateTime PaymentDate { get; set; }
        public string GrossAmount { get; set; }
        public string FeeAmount { get; set; }
        public string TaxAmount { get; set; }
        public object ExchangeRate { get; set; }
        public string PaymentStatus { get; set; }
        public string PendingReason { get; set; }
        public string ReasonCode { get; set; }
        public string ProtectionEligibility { get; set; }
        public string ProtectionEligibilityType { get; set; }
        public SellerDetails SellerDetails { get; set; }
    }
    public class SellerDetails
    {
        public string PayPalAccountID { get; set; }
        public string SecureMerchantAccountID { get; set; }
    }
}
