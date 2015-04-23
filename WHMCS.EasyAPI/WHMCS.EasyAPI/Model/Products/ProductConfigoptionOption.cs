using Newtonsoft.Json;

namespace Whmcs.Model.Products
{
    public class ProductConfigoptionOption
    {
        [JsonProperty("id")]
        public int? ProductId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("recurring")]
        public int Recurring { get; set; }

        [JsonProperty("pricing")]
        public ProductPricing Pricing { get; set; }
        
    }
}
