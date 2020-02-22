namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionSchedule : StripeEntity<SubscriptionSchedule>, IHasId, IHasMetadata, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("canceled_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? CanceledAt { get; set; }

        [JsonProperty("completed_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? CompletedAt { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("current_phase")]
        public SubscriptionScheduleCurrentPhase CurrentPhase { get; set; }

        [JsonProperty("customer")]
        public todo-thingy Customer { get; set; }

        [JsonProperty("default_settings")]
        public SubscriptionScheduleDefaultSettings DefaultSettings
        {
            get;
            set;

        }

        [JsonProperty("end_behavior")]
        public string EndBehavior { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("phases")]
        public List<SubscriptionSchedulePhase> Phases { get; set; }

        [JsonProperty("released_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? ReleasedAt { get; set; }

        [JsonProperty("released_subscription")]
        public string ReleasedSubscription { get; set; }

        [JsonProperty("renewal_interval")]
        public SubscriptionScheduleRenewalInterval RenewalInterval
        {
            get;
            set;

        }

        [JsonProperty("status")]
        public string Status { get; set; }

        #region Expandable Subscription
        [JsonIgnore]
        public string SubscriptionId
        {
            get => this.InternalSubscription?.Id;
            set => this.InternalSubscription = SetExpandableFieldId(value, this.InternalSubscription);
        }
        [JsonIgnore]
        public Subscription Subscription
        {
            get => this.InternalSubscription?.ExpandedObject;
            set => this.InternalSubscription = SetExpandableFieldObject(value, this.InternalSubscription);
        }

        [JsonProperty("subscription")]
        [JsonConverter(typeof(ExpandableFieldConverter<Subscription>))]
        internal ExpandableField<Subscription> InternalSubscription
        {
            get;
            set;

        }
        #endregion
    }
}
