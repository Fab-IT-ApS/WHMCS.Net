
using Newtonsoft.Json;

namespace WHMCS.Model.ClientsProducts
{
    public class ProductCustomField
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
