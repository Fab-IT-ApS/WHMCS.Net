using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WHMCS.EasyAPI.Model.Products
{
    public class Product
    {
        [JsonProperty("pid")]
        public int? ProductId { get; set; }

        [JsonProperty("gid")]
        public int? GroupId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("module")]
        public string Module { get; set; }

        [JsonProperty("paytype")]
        public string Paytype { get; set; }

        [JsonProperty("pricing")]
        public ProductPricing Pricing { get; set; }

        [JsonProperty("configoptions")]
        public ProductConfigoptions ConfigOptions { get; set; }
    }
}
