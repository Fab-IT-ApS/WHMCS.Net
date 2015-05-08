using Newtonsoft.Json;

namespace WHMCS.Model.Contacts
{
    public class Contact
    {
        [JsonProperty("íd")]
        public string ID { get; set; }

        [JsonProperty("userid")]
        public string UserId { get; set; }

        [JsonProperty("firstname")]
        public string FirstName { get; set; }

        [JsonProperty("lastname")]
        public string LastName { get; set; }

        [JsonProperty("companyname")]
        public string CompanyName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postcode")]
        public string Postcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("phonenumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("subaccount")]
        public string SubAccount { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("permissions")]
        public string Permissions { get; set; }

        [JsonProperty("domainemails")]
        public string DomainEmails { get; set; }

        [JsonProperty("generalemails")]
        public string GeneralEmails { get; set; }

        [JsonProperty("invoiceemails")]
        public string InvoiceEmails { get; set; }

        [JsonProperty("productemails")]
        public string ProductEmails { get; set; }

        [JsonProperty("supportemails")]
        public string SupportEmails { get; set; }

        [JsonProperty("affiliateemails")]
        public string AffiliateEmails { get; set; }

        [JsonProperty("pwresetkey")]
        public string PwResetKey { get; set; }

        [JsonProperty("pwresetexpiry")]
        public string PwResetExpiry { get; set; }

    }
}
