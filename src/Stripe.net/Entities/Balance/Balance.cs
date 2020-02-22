namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Balance : StripeEntity<Balance>, IHasObject
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("available")]
        public List<BalanceAvailable> Available { get; set; }

        [JsonProperty("connect_reserved")]
        public List<BalanceConnectReserved> ConnectReserved { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("pending")]
        public List<BalancePending> Pending { get; set; }
    }
}
