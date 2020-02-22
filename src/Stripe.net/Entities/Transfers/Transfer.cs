namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Transfer : StripeEntity<Transfer>, IHasId, IHasMetadata, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("amount_reversed")]
        public long AmountReversed { get; set; }

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

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        #region Expandable Destination
        [JsonIgnore]
        public string DestinationId
        {
            get => this.InternalDestination?.Id;
            set => this.InternalDestination = SetExpandableFieldId(value, this.InternalDestination);
        }
        [JsonIgnore]
        public Destination Destination
        {
            get => this.InternalDestination?.ExpandedObject;
            set => this.InternalDestination = SetExpandableFieldObject(value, this.InternalDestination);
        }

        [JsonProperty("destination")]
        [JsonConverter(typeof(ExpandableFieldConverter<Destination>))]
        internal ExpandableField<Destination> InternalDestination { get; set; }
        #endregion

        [JsonProperty("destination_payment")]
        public todo-thingy DestinationPayment { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("reversals")]
        public StripeList<TransferReversal> Reversals { get; set; }

        [JsonProperty("reversed")]
        public bool Reversed { get; set; }

        #region Expandable SourceTransaction
        [JsonIgnore]
        public string SourceTransactionId
        {
            get => this.InternalSourceTransaction?.Id;
            set => this.InternalSourceTransaction = SetExpandableFieldId(value, this.InternalSourceTransaction);
        }
        [JsonIgnore]
        public SourceTransaction SourceTransaction
        {
            get => this.InternalSourceTransaction?.ExpandedObject;
            set => this.InternalSourceTransaction = SetExpandableFieldObject(value, this.InternalSourceTransaction);
        }

        [JsonProperty("source_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<SourceTransaction>))]
        internal ExpandableField<SourceTransaction> InternalSourceTransaction
        {
            get;
            set;

        }
        #endregion

        [JsonProperty("source_type")]
        public string SourceType { get; set; }

        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
