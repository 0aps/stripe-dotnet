namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SetupIntentCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("confirm")]
        public bool Confirm { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("mandate_data")]
        public SetupIntentMandateData MandateData { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("on_behalf_of")]
        public string OnBehalfOf { get; set; }

        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        [JsonProperty("payment_method_options")]
        public SetupIntentPaymentMethodOptions PaymentMethodOptions
        {
            get;
            set;

        }

        [JsonProperty("payment_method_types")]
        public List<string> PaymentMethodTypes { get; set; }

        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        [JsonProperty("single_use")]
        public SetupIntentSingleUse SingleUse { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }
    }
}
