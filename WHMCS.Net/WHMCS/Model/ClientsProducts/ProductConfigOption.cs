using Newtonsoft.Json;

namespace WHMCS.Model.ClientsProducts
{
    public class ProductConfigOption
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("option")]
        public string Option { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
