namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class RecipientUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("bank_account")]
        public string BankAccount { get; set; }

        [JsonProperty("card")]
        public string Card { get; set; }

        [JsonProperty("default_card")]
        public string DefaultCard { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tax_id")]
        public string TaxId { get; set; }
    }
}