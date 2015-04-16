using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WHMCS.EasyAPI.Model.Products
{
    public class ProductConfigoptionOption
    {
        [JsonProperty("id")]
        public int? ProductId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
