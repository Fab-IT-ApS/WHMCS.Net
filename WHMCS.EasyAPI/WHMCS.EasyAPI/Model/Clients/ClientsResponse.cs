using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WHMCS.EasyAPI.Model.Clients
{
    public class ClientsResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("totalresults")]
        public int TotalResults { get; set; }

        [JsonProperty("startnumber")]
        public int StartNumber { get; set; }

        [JsonProperty("numreturned")]
        public int NumberLimit { get; set; }

        [JsonProperty("clients")]
        public Clients Clients { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
