namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Mandate : StripeEntity<Mandate>, IHasId, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("customer_acceptance")]
        public MandateCustomerAcceptance CustomerAcceptance { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("multi_use")]
        public MandateMultiUse MultiUse { get; set; }

        [JsonProperty("payment_method")]
        public todo-thingy PaymentMethod { get; set; }

        [JsonProperty("payment_method_details")]
        public MandatePaymentMethodDetails PaymentMethodDetails { get; set; }

        [JsonProperty("single_use")]
        public MandateSingleUse SingleUse { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
