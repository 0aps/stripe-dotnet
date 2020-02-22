namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AuthorizationUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("metadata")]
        public emptyStringable Metadata { get; set; }
    }
}
