using Newtonsoft.Json;

namespace WHMCS.Model.ClientsProducts
{
    public class ClientsProductsResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("clientid")]
        public int? ClientId { get; set; }

        [JsonProperty("serviceid")]
        public int? ServiceId { get; set; }

        [JsonProperty("pid")]
        public int? ProductId { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("totalresults")]
        public int TotalResults { get; set; }

        [JsonProperty("startnumber")]
        public int StartNumber { get; set; }

        [JsonProperty("numreturned")]
        public int NumberReturned { get; set; }

        [JsonProperty("products")]
        public Products Products { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
