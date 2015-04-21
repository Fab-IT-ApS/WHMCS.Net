using Newtonsoft.Json;

namespace Whmcs.Model.ClientDetails
{
    public class CustomField
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
