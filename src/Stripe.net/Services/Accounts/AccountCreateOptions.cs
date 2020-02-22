namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("account_token")]
        public string AccountToken { get; set; }

        [JsonProperty("business_profile")]
        public AccountBusinessProfile BusinessProfile { get; set; }

        [JsonProperty("business_type")]
        public string BusinessType { get; set; }

        [JsonProperty("company")]
        public AccountCompany Company { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("default_currency")]
        public string DefaultCurrency { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("external_account")]
        public string ExternalAccount { get; set; }

        [JsonProperty("individual")]
        public AccountIndividual Individual { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("requested_capabilities")]
        public List<string> RequestedCapabilities { get; set; }

        [JsonProperty("settings")]
        public AccountSettings Settings { get; set; }

        [JsonProperty("tos_acceptance")]
        public AccountTosAcceptance TosAcceptance { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
