using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WHMCS.EasyAPI.Model.Products
{
    public class ProductsResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("totalresults")]
        public int TotalResults { get; set; }

        [JsonProperty("products")]
        public Products Products { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
