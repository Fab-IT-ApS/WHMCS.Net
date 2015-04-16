using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WHMCS.EasyAPI.Model.Products
{
    public class ProductPricingDKK
    {
        [JsonProperty("prefix")]
        public string Prefix { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        [JsonProperty("msetupfee")]
        public double? MonthlySetupFee { get; set; }

        [JsonProperty("QuarterlySetupFee")]
        public double? QuarterlySetupFee { get; set; }

        [JsonProperty("ssetupfee")]
        public double? SemiAnuallySetupFee { get; set; }

        [JsonProperty("asetupfee")]
        public double? AnuallySetupFee { get; set; }

        [JsonProperty("bsetupfee")]
        public double? BienniallySetupFee { get; set; }

        [JsonProperty("tsetupfee")]
        public double? TrienniallySetupFee { get; set; }

        [JsonProperty("monthly")]
        public double? Monthly { get; set; }

        [JsonProperty("quarterly")]
        public double? Quarterly { get; set; }

        [JsonProperty("semiannually")]
        public double? SemiAnnually { get; set; }

        [JsonProperty("annually")]
        public double? Annually { get; set; }

        [JsonProperty("biennially")]
        public double? Biennially { get; set; }

        [JsonProperty("triennially")]
        public double? Triennially { get; set; }
    }
}
