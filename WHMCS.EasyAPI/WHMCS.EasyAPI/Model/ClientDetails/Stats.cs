using Newtonsoft.Json;

namespace Whmcs.Model.ClientDetails
{
    public class Stats
    {
        [JsonProperty("numdueinvoices")]
        public int? NumberOfDueInvoices { get; set; }

        [JsonProperty("dueinvoicesbalance")]
        public string DueInvoicesBalance { get; set; }

        [JsonProperty("income")]
        public string Income { get; set; }

        [JsonProperty("incredit")]
        public bool InCredit { get; set; }

        [JsonProperty("creditbalance")]
        public string CreditBalance { get; set; }

        [JsonProperty("numoverdueinvoices")]
        public string NumberOfOverDueInvoices { get; set; }

        [JsonProperty("overdueinvoicesbalance")]
        public string OverdueInvoicesBalance { get; set; }

        [JsonProperty("numpaidinvoices")]
        public string NumberOfPaidInvoices { get; set; }

        [JsonProperty("paidinvoicesamount")]
        public string PaidInvoicesAmount { get; set; }

        [JsonProperty("numunpaidinvoices")]
        public string NumberOfUnpaidInvoices { get; set; }

        [JsonProperty("unpaidinvoicesamount")]
        public string UnpaidInvoicesAmount { get; set; }

        [JsonProperty("numcancelledinvoices")]
        public string numberOfCancelledInvoices { get; set; }

        [JsonProperty("cancelledinvoicesamount")]
        public string CancelledInvoicesAmount { get; set; }

        [JsonProperty("numrefundedinvoices")]
        public int NumberOfRefundedInvoices { get; set; }

        [JsonProperty("refundedinvoicesamount")]
        public string RefundedInvoicesAmount { get; set; }

        [JsonProperty("numcollectionsinvoices")]
        public int NumberOfCollectionsInvoices { get; set; }

        [JsonProperty("collectionsinvoicesamount")]
        public string CollectionsInvoicesAmount { get; set; }

        [JsonProperty("productsnumactivehosting")]
        public int ProductsNumberActiveHosting { get; set; }

        [JsonProperty("productsnumhosting")]
        public int ProductsNumberHosting { get; set; }

        [JsonProperty("productsnumactivereseller")]
        public int ProductsNumberActiveReseller { get; set; }

        [JsonProperty("productsnumreseller")]
        public int ProductsNumberReseller { get; set; }

        [JsonProperty("productsnumactiveservers")]
        public int ProductsNumberActiveServers { get; set; }

        [JsonProperty("productsnumservers")]
        public int ProductsNumberServers { get; set; }

        [JsonProperty("productsnumactiveother")]
        public string ProductsNumberActiveOther { get; set; }

        [JsonProperty("productsnumother")]
        public int ProductsNumberOther { get; set; }

        [JsonProperty("productsnumactive")]
        public int ProductsNumberActive { get; set; }

        [JsonProperty("productsnumtotal")]
        public int ProductsNumberTotal { get; set; }

        [JsonProperty("numactivedomains")]
        public int NumberOfActiveDomains { get; set; }

        [JsonProperty("numdomains")]
        public int NumberOfDomains { get; set; }

        [JsonProperty("numacceptedquotes")]
        public int NumberOfAcceptedQuotes { get; set; }

        [JsonProperty("numquotes")]
        public int NumberOfQuotes { get; set; }

        [JsonProperty("numtickets")]
        public int NumberOfTickets { get; set; }

        [JsonProperty("numactivetickets")]
        public int NumberOfActiveTickets { get; set; }

        [JsonProperty("numaffiliatesignups")]
        public string NumberOfAffiliateSignups { get; set; }
    }
}
