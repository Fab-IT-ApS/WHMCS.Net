using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WHMCS.EasyAPI.Model.Clients;

namespace WHMCS.EasyAPI.Model.ClientDetails
{
    public class Details
    {
        [JsonProperty("userid")]
        public int? CustomerId { get; set; }

        [JsonProperty("id")]
        public int? id { get; set; }

        [JsonProperty("firstname")]
        public string FirstName { get; set; }

        [JsonProperty("lastname")]
        public string LastName { get; set; }

        [JsonProperty("fullname")]
        public string FullName { get; set; }

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

        [JsonProperty("fullstate")]
        public string FullState { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postcode")]
        public string Postcode { get; set; }

        [JsonProperty("countrycode")]
        public string Countrycode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("statecode")]
        public string Statecode { get; set; }

        [JsonProperty("countryname")]
        public string CountryName { get; set; }

        [JsonProperty("phonecc")]
        public int PhoneCountryCode { get; set; }

        [JsonProperty("phonenumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("phonenumberformatted")]
        public string PhoneNumberFormatted { get; set; }

        [JsonProperty("billingcid")]
        public string BillingCId { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("twofaenabled")]
        public bool TwoFactorAuthenabled { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("defaultgateway")]
        public string DefaultGateway { get; set; }

        [JsonProperty("cctype")]
        public string CreditCardType { get; set; }

        [JsonProperty("cclastfour")]
        public string CreditCardLastFour { get; set; }

        [JsonProperty("securityqid")]
        public string SecurityQId { get; set; }

        [JsonProperty("securityqans")]
        public string SecurityQuans { get; set; }

        [JsonProperty("groupid")]
        public string GroupId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("credit")]
        public string Credit { get; set; }

        [JsonProperty("taxexempt")]
        public string TaxExempt { get; set; }

        [JsonProperty("latefeeoveride")]
        public string LateFeeOveride { get; set; }

        [JsonProperty("overideduenotices")]
        public string OverideDueNotices { get; set; }

        [JsonProperty("separateinvoices")]
        public string SeparateInvoices { get; set; }

        [JsonProperty("disableautocc")]
        public string DisableAutoCC { get; set; }

        [JsonProperty("emailoptout")]
        public string EmailOptout { get; set; }

        [JsonProperty("overrideautoclose")]
        public string OverrideAutoClose { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("lastlogin")]
        public string LastLogin { get; set; }

        [JsonProperty("customfields")]
        public List<CustomField> CustomFields { get; set; }

    }
}
