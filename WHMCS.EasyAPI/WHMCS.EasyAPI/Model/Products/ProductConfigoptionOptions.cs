using System.Collections.Generic;
using Newtonsoft.Json;

namespace Whmcs.Model.Products
{
    public class ProductConfigoptionOptions
    {
        [JsonProperty("option")]
        public List<ProductConfigoptionOption> Option { get; set; }
    }
}
