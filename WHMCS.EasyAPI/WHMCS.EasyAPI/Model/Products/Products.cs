using System.Collections.Generic;
using Newtonsoft.Json;

namespace Whmcs.Model.Products
{
    public class Products
    {
        [JsonProperty("product")]
        public List<Product> Product { get; set; }
    }
}
