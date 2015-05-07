using Newtonsoft.Json;

namespace WHMCS.Model.Products
{
    public class ProductConfigoption
    {
        [JsonProperty("id")]
        public int? ProductId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("options")]
        public ProductConfigoptionOptions Options { get; set; }
    }
}
