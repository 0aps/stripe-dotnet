namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ApplicationFee : StripeEntity<ApplicationFee>, IHasId, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("account")]
        public todo-thingy Account { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("amount_refunded")]
        public long AmountRefunded { get; set; }

        [JsonProperty("application")]
        public todo-thingy Application { get; set; }

        #region Expandable BalanceTransaction
        [JsonIgnore]
        public string BalanceTransactionId
        {
            get => this.InternalBalanceTransaction?.Id;
            set => this.InternalBalanceTransaction = SetExpandableFieldId(value, this.InternalBalanceTransaction);
        }
        [JsonIgnore]
        public BalanceTransaction BalanceTransaction
        {
            get => this.InternalBalanceTransaction?.ExpandedObject;
            set => this.InternalBalanceTransaction = SetExpandableFieldObject(value, this.InternalBalanceTransaction);
        }

        [JsonProperty("balance_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<BalanceTransaction>))]
        internal ExpandableField<BalanceTransaction> InternalBalanceTransaction
        {
            get;
            set;

        }
        #endregion

        [JsonProperty("charge")]
        public todo-thingy Charge { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        #region Expandable OriginatingTransaction
        [JsonIgnore]
        public string OriginatingTransactionId
        {
            get => this.InternalOriginatingTransaction?.Id;
            set => this.InternalOriginatingTransaction = SetExpandableFieldId(value, this.InternalOriginatingTransaction);
        }
        [JsonIgnore]
        public OriginatingTransaction OriginatingTransaction
        {
            get => this.InternalOriginatingTransaction?.ExpandedObject;
            set => this.InternalOriginatingTransaction = SetExpandableFieldObject(value, this.InternalOriginatingTransaction);
        }

        [JsonProperty("originating_transaction")]
        [JsonConverter(
            typeof(ExpandableFieldConverter<OriginatingTransaction>)
        )]
        internal ExpandableField<OriginatingTransaction> InternalOriginatingTransaction
        {
            get;
            set;

        }
        #endregion

        [JsonProperty("refunded")]
        public bool Refunded { get; set; }

        [JsonProperty("refunds")]
        public StripeList<FeeRefund> Refunds { get; set; }
    }
}
