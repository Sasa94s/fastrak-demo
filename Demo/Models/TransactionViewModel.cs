using System.Text.Json.Serialization;

namespace Demo.Models
{
    public class TransactionViewModel
    {
        [JsonPropertyName("transactions")]
        public List<TransactionDetails> Transactions { get; set; }
    }

    public class PresentmentShopMoney
    {
        [JsonPropertyName("amount")]
        public string Amount { get; set; }
        [JsonPropertyName("currency")]
        public string Currency { get; set; }
    }

    public class ReceiptDetails
    {
        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }
        [JsonPropertyName("parent_transaction_id")]
        public long? ParentTransactionId { get; set; }
        [JsonPropertyName("transaction_type")]
        public string TransactionType { get; set; }
        [JsonPropertyName("payment_type")]
        public string PaymentType { get; set; }
        [JsonPropertyName("payment_date")]
        public DateTime PaymentDate { get; set; }
        [JsonPropertyName("gross_amount")]
        public string GrossAmount { get; set; }
        [JsonPropertyName("gross_amount_currency_id")]
        public string GrossAmountCurrencyId { get; set; }
        [JsonPropertyName("fee_amount")]
        public string FeeAmount { get; set; }
        [JsonPropertyName("fee_amount_currency_id")]
        public string FeeAmountCurrencyId { get; set; }
        [JsonPropertyName("tax_amount")]
        public string TaxAmount { get; set; }
        [JsonPropertyName("tax_amount_currency_id")]
        public string TaxAmountCurrencyId { get; set; }
        [JsonPropertyName("payment_status")]
        public string PaymentStatus { get; set; }
        [JsonPropertyName("pending_reason")]
        public string PendingReason { get; set; }
        [JsonPropertyName("reason_code")]
        public string ReasonCode { get; set; }
        [JsonPropertyName("protection_eligibility")]
        public string ProtectionEligibility { get; set; }
        [JsonPropertyName("protection_eligibility_type")]
        public string ProtectionEligibilityType { get; set; }
        [JsonPropertyName("pay_pal_account_id")]
        public string PayPalAccountId { get; set; }
        [JsonPropertyName("secure_merchant_account_id")]
        public string SecureMerchantAccountId { get; set; }
        public string Token { get; set; }
        public PaymentInfo PaymentInfo { get; set; }
        public bool SuccessPageRedirectRequested { get; set; }
        [JsonPropertyName("success_page_redirect_requested")]
        public bool SuccessPageRedirectRequested_copy { get; set; }//Taking duplicates as shopify returns duplcates some of objects are having this property or some of not
        [JsonPropertyName("net_refund_amount_currency_id")]
        public string NetRefundAmountCurrencyId { get; set; }
        [JsonPropertyName("fee_refund_amount_currency_id")]
        public string FeeRefundAmountCurrencyId { get; set; }
        [JsonPropertyName("gross_refund_amount_currency_id")]
        public string GrossRefundAmountCurrencyId { get; set; }
        [JsonPropertyName("total_refunded_amount_currency_id")]
        public string TotalRefundedAmountCurrencyId { get; set; }
        [JsonPropertyName("refund_status")]
        public string RefundStatus { get; set; }
        public DateTime? Timestamp { get; set; }
        [JsonPropertyName("timestamp")]
        public DateTime timestamp_copy { get; set; }
        public string Ack { get; set; }
        [JsonPropertyName("ack")]
        public string ack_copy { get; set; }
        public string CorrelationID { get; set; }
        [JsonPropertyName("correlation_id")]
        public string CorrelationId_copy { get; set; }
        public string Version { get; set; }
        [JsonPropertyName("version")]
        public string version_copy { get; set; }
        public string Build { get; set; }
        [JsonPropertyName("build")]
        public string Build_copy { get; set; }
        public string RefundTransactionID { get; set; }
        [JsonPropertyName("refund_transaction_id")]
        public string RefundTransactionId_copy { get; set; }
        public string NetRefundAmount { get; set; }
        [JsonPropertyName("net_refund_amount")]
        public string NetRefundAmount_copy { get; set; }
        public string FeeRefundAmount { get; set; }
        [JsonPropertyName("fee_refund_amount")]
        public string FeeRefundAmount_copy { get; set; }
        public string GrossRefundAmount { get; set; }
        [JsonPropertyName("gross_refund_amount")]
        public string GrossRefundAmount_copy { get; set; }
        public string TotalRefundedAmount { get; set; }
        [JsonPropertyName("total_refunded_amount")]
        public string TotalRefundedAmount_copy { get; set; }
        public RefundInfo RefundInfo { get; set; }
    }

    public class RefundInfo
    {
        public string RefundStatus { get; set; }
        public string PendingReason { get; set; }
    }

    public class TotalUnsettledSet
    {
        [JsonPropertyName("presentment_money")]
        public PresentmentShopMoney PresentmentMoney { get; set; }
        [JsonPropertyName("shop_money")]
        public PresentmentShopMoney ShopMoney { get; set; }
    }

    public class TransactionDetails
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("admin_graphql_api_id")]
        public string? AdminGraphqlApiId { get; set; }
        [JsonPropertyName("amount")]
        public decimal Amount { get; set; }
        [JsonPropertyName("currency")]
        public string? Currency { get; set; }
        [JsonPropertyName("kind")]
        public string? Kind { get; set; }
        [JsonPropertyName("gateway")]
        public string? Gateway { get; set; }
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        [JsonPropertyName("authorization")]
        public string? Authorization { get; set; }
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonPropertyName("device_id")]
        public long? DeviceId { get; set; }
        [JsonPropertyName("error_code")]
        public string? ErrorCode { get; set; }
        [JsonPropertyName("location_id")]
        public long? LocationId { get; set; }
        [JsonPropertyName("test")]
        public bool Test { get; set; }
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
        [JsonPropertyName("source_name")]
        public string? SourceName { get; set; }

        [JsonPropertyName("user_id")]
        public long? UserId { get; set; }
        [JsonPropertyName("receipt")]
        public ReceiptDetails Receipt { get; set; }
        [JsonPropertyName("total_unsettled_set")]
        public TotalUnsettledSet TotalUnsettledSet { get; set; }
        [JsonPropertyName("manual_payment_gateway")]
        public bool ManualPaymentGateway { get; set; }
    }

}
