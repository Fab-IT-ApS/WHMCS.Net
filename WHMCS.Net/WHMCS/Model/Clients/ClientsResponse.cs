using Newtonsoft.Json;

namespace WHMCS.Model.Clients
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
