namespace Stripe.Radar
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class EarlyFraudWarning : StripeEntity<EarlyFraudWarning>, IHasId, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("actionable")]
        public bool Actionable { get; set; }

        [JsonProperty("charge")]
        public todo-thingy Charge { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("fraud_type")]
        public string FraudType { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }
    }
}
