using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WHMCS.Model.ClientsProducts
{
    public class ProductConfigOptions
    {
        [JsonProperty("configoption")]
        public IEnumerable<ProductConfigOption> ConfigOption { get; set; }
    }
}
