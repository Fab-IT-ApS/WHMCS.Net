using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WHMCS.EasyAPI.Model.Products
{
    public class Products
    {
        [JsonProperty("product")]
        public List<Product> Product { get; set; }
    }
}
