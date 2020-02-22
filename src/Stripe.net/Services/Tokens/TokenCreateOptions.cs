namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class TokenCreateOptions : BaseOptions
    {
        [JsonProperty("bank_account")]
        public TokenBankAccount BankAccount { get; set; }

        [JsonProperty("card")]
        public todo-thingy Card { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("person")]
        public TokenPerson Person { get; set; }

        [JsonProperty("pii")]
        public TokenPii Pii { get; set; }
    }
}
