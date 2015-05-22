using System.Collections.Generic;
using Newtonsoft.Json;

namespace WHMCS.Model.Products
{
    public class ProductConfigoptionOptions
    {
        [JsonProperty("option")]
        public IEnumerable<ProductConfigoptionOption> Option { get; set; }
    }
}
