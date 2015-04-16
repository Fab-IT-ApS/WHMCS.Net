using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WHMCS.EasyAPI.Model.Clients
{
    public class Client
    {
        [JsonProperty("id")]
        public int? CustomerId { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("companyname")]
        public string Companyname { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("datecreated")]
        public string DateCreated { get; set; }

        [JsonProperty("groupid")]
        public int? GroupId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
