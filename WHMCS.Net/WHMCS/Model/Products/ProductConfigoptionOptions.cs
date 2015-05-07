using System.Collections.Generic;
using Newtonsoft.Json;

namespace WHMCS.Model.Products
{
    public class ProductConfigoptionOptions
    {
        [JsonProperty("option")]
        public List<ProductConfigoptionOption> Option { get; set; }
    }
}
