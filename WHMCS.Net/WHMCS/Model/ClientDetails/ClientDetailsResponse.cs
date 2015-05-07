using Newtonsoft.Json;

namespace WHMCS.Model.ClientDetails
{
    public class ClientDetailsResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("client")]
        public Details Client { get; set; }
        
        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
