using Newtonsoft.Json;

namespace Whmcs.Model.Products
{
    public class ProductConfigoptionOption
    {
        [JsonProperty("id")]
        public int? ProductId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
