using System.Collections.Generic;
using Newtonsoft.Json;

namespace WHMCS.Model.Products
{
    public class ProductConfigoptions
    {
        [JsonProperty("configoption")]
        public IEnumerable<ProductConfigoption> Configoption { get; set; }
    }
}
