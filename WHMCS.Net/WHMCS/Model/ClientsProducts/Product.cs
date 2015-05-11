using Newtonsoft.Json;

namespace WHMCS.Model.ClientsProducts
{
    public class Product
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("clientid")]
        public string ClientId { get; set; }

        [JsonProperty("orderid")]
        public string OrderId { get; set; }

        [JsonProperty("pid")]
        public string ProductId { get; set; }

        [JsonProperty("regdate")]
        public string DateRegistered { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("groupname")]
        public string GroupName { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("dedicatedip")]
        public string DedicatedIP { get; set; }

        [JsonProperty("serverid")]
        public string ServerId { get; set; }

        [JsonProperty("servername")]
        public string ServerName { get; set; }

        [JsonProperty("serverip")]
        public string ServerIP { get; set; }

        [JsonProperty("serverhostname")]
        public string ServerHostName { get; set; }

        [JsonProperty("firstpaymentamount")]
        public string FirstPaymentAmount { get; set; }

        [JsonProperty("recurringamount")]
        public string RecurringAmount { get; set; }

        [JsonProperty("paymentmethod")]
        public string PaymentMethod { get; set; }

        [JsonProperty("paymentmethodname")]
        public string PaymentMethodName { get; set; }

        [JsonProperty("billingcycle")]
        public string BillingCycle { get; set; }

        [JsonProperty("nextduedate")]
        public string NextDueDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("subscriptionid")]
        public string SubscriptionId { get; set; }

        [JsonProperty("promoid")]
        public string PromotionId { get; set; }

        [JsonProperty("overideautosuspend")]
        public string OverrideAutoSuspend { get; set; }

        [JsonProperty("overidesuspenduntil")]
        public string OverrideSuspendUntil { get; set; }

        [JsonProperty("ns1")]
        public string Nameserver1 { get; set; }

        [JsonProperty("ns2")]
        public string Nameserver2 { get; set; }

        [JsonProperty("assignedips")]
        public string AssignedIPs { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("diskusage")]
        public string DiskUsage { get; set; }

        [JsonProperty("disklimit")]
        public string DiskLimit { get; set; }

        [JsonProperty("bwusage")]
        public string BwUsage { get; set; }

        [JsonProperty("bwlimit")]
        public string BwLimit { get; set; }

        [JsonProperty("lastupdate")]
        public string LastUpdate { get; set; }

        [JsonProperty("customfields")]
        public ProductCustomFields CustomFields { get; set; }

        [JsonProperty("configoptions")]
        public ProductConfigOptions ConfigOptions { get; set; }
    }
}
