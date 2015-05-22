using System.Collections.Generic;
using Newtonsoft.Json;

namespace WHMCS.Model.Products
{
    public class Products
    {
        [JsonProperty("product")]
        public IEnumerable<Product> Product { get; set; }
    }
}
