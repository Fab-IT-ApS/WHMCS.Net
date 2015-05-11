using System.Collections.Generic;
using Newtonsoft.Json;

namespace WHMCS.Model.ClientsProducts
{
    public class Products
    {
        [JsonProperty("products")]
        public List<Product> Product { get; set; }
    }
}
