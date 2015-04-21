using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WHMCS.EasyAPI.Model.ClientDetails
{
    public class ClientDetailsResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("client")]
        public Details Client { get; set; }
        
        [JsonProperty("stats")]
        public Stats Stats { get; set; }
    }
}
