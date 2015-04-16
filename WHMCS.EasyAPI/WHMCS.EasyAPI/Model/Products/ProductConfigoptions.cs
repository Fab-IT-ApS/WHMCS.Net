using System.Collections.Generic;
using Newtonsoft.Json;

namespace WHMCS.EasyAPI.Model.Products
{
    public class ProductConfigoptions
    {
        [JsonProperty("configoption")]
        public List<ProductConfigoption> Configoption { get; set; }
    }
}
