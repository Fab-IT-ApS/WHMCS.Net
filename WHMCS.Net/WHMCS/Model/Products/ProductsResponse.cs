﻿using Newtonsoft.Json;

namespace WHMCS.Model.Products
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
