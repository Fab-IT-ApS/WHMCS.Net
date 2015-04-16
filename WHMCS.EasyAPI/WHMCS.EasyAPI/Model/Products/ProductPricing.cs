using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WHMCS.EasyAPI.Model.Products
{
    public class ProductPricing
    {
        public ProductPricingDKK DKK { get; set; }
        public ProductPricingEUR EUR { get; set; }
        public ProductPricingUSD USD { get; set; }
    }
}
