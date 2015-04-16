using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WHMCS.EasyAPI.Model.Products
{
    public class ProductConfigoptionOptions
    {
        [JsonProperty("option")]
        public List<ProductConfigoptionOption> Options { get; set; }
    }
}
