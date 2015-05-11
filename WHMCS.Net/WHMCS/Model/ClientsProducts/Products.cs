using System.Collections.Generic;
using Newtonsoft.Json;

namespace WHMCS.Model.ClientsProducts
{
    public class Products
    {
        [JsonProperty("product")]
        public List<Product> Product { get; set; }
    }
}
