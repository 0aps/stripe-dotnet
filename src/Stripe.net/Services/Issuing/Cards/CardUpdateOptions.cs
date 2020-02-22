namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CardUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("authorization_controls")]
        public CardAuthorizationControls AuthorizationControls { get; set; }

        [JsonProperty("metadata")]
        public emptyStringable Metadata { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
