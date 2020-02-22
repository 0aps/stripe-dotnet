namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Recipient : StripeEntity<Recipient>, IHasId, IHasMetadata, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("active_account")]
        public BankAccount ActiveAccount { get; set; }

        [JsonProperty("cards")]
        public StripeList<Card> Cards { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        #region Expandable DefaultCard
        [JsonIgnore]
        public string DefaultCardId
        {
            get => this.InternalDefaultCard?.Id;
            set => this.InternalDefaultCard = SetExpandableFieldId(value, this.InternalDefaultCard);
        }
        [JsonIgnore]
        public DefaultCard DefaultCard
        {
            get => this.InternalDefaultCard?.ExpandedObject;
            set => this.InternalDefaultCard = SetExpandableFieldObject(value, this.InternalDefaultCard);
        }

        [JsonProperty("default_card")]
        [JsonConverter(typeof(ExpandableFieldConverter<DefaultCard>))]
        internal ExpandableField<DefaultCard> InternalDefaultCard { get; set; }
        #endregion

        [JsonProperty("deleted", NullValueHandling=NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        #region Expandable MigratedTo
        [JsonIgnore]
        public string MigratedToId
        {
            get => this.InternalMigratedTo?.Id;
            set => this.InternalMigratedTo = SetExpandableFieldId(value, this.InternalMigratedTo);
        }
        [JsonIgnore]
        public MigratedTo MigratedTo
        {
            get => this.InternalMigratedTo?.ExpandedObject;
            set => this.InternalMigratedTo = SetExpandableFieldObject(value, this.InternalMigratedTo);
        }

        [JsonProperty("migrated_to")]
        [JsonConverter(typeof(ExpandableFieldConverter<MigratedTo>))]
        internal ExpandableField<MigratedTo> InternalMigratedTo { get; set; }
        #endregion

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rolled_back_from")]
        public todo-thingy RolledBackFrom { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }
    }
}
