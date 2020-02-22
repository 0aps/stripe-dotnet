namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("mandate")]
        public SourceMandate Mandate { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("owner")]
        public SourceOwner Owner { get; set; }

        [JsonProperty("source_order")]
        public SourceSourceOrder SourceOrder { get; set; }
    }
}
