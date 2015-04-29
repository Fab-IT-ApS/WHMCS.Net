using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Whmcs.DataStores;
using Whmcs.Model.Products;

namespace Whmcs.Example
{
    class Program
    {
        public static readonly string RawJsonProducts = "{\"result\":\"success\",\"totalresults\":1,\"products\":{\"product\":[{\"pid\":\"98\",\"gid\":\"25\",\"type\":\"other\",\"name\":\"TestProduct#1\",\"description\":\"This is a Product#1\\r\\nDescription\\r\\nPage\",\"module\":\"\",\"paytype\":\"recurring\",\"pricing\":{\"DKK\":{\"prefix\":\"\",\"suffix\":\" kr\",\"msetupfee\":\"0.00\",\"qsetupfee\":\"0.00\",\"ssetupfee\":\"0.00\",\"asetupfee\":\"0.00\",\"bsetupfee\":\"0.00\",\"tsetupfee\":\"0.00\",\"monthly\":\"-1.00\",\"quarterly\":\"-1.00\",\"semiannually\":\"-1.00\",\"annually\":\"-1.00\",\"biennially\":\"-1.00\",\"triennially\":\"-1.00\"},\"EUR\":{\"prefix\":\"\\u20ac\",\"suffix\":\"EUR\",\"msetupfee\":\"0.00\",\"qsetupfee\":\"0.00\",\"ssetupfee\":\"0.00\",\"asetupfee\":\"0.00\",\"bsetupfee\":\"0.00\",\"tsetupfee\":\"0.00\",\"monthly\":\"-1.00\",\"quarterly\":\"-1.00\",\"semiannually\":\"-1.00\",\"annually\":\"-1.00\",\"biennially\":\"-1.00\",\"triennially\":\"-1.00\"},\"USD\":{\"prefix\":\"$\",\"suffix\":\"USD\",\"msetupfee\":\"0.00\",\"qsetupfee\":\"0.00\",\"ssetupfee\":\"0.00\",\"asetupfee\":\"0.00\",\"bsetupfee\":\"0.00\",\"tsetupfee\":\"0.00\",\"monthly\":\"-1.00\",\"quarterly\":\"-1.00\",\"semiannually\":\"-1.00\",\"annually\":\"-1.00\",\"biennially\":\"-1.00\",\"triennially\":\"-1.00\"}},\"customfields\":{\"customfield\":[]},\"configoptions\":{\"configoption\":[{\"id\":\"11\",\"name\":\"Performance Dedicated server\",\"type\":\"3\",\"options\":{\"option\":[{\"id\":\"23\",\"name\":\"Opgrader standard diske til 600GB SSD\",\"recurring\":0,\"pricing\":{\"DKK\":{\"msetupfee\":\"450.00\",\"qsetupfee\":\"0.00\",\"ssetupfee\":\"0.00\",\"asetupfee\":\"0.00\",\"bsetupfee\":\"0.00\",\"tsetupfee\":\"0.00\",\"monthly\":\"400.00\",\"quarterly\":\"1000.00\",\"semiannually\":\"0.00\",\"annually\":\"0.00\",\"biennially\":\"0.00\",\"triennially\":\"0.00\"},\"EUR\":{\"msetupfee\":\"60.30\",\"qsetupfee\":\"0.00\",\"ssetupfee\":\"0.00\",\"asetupfee\":\"0.00\",\"bsetupfee\":\"0.00\",\"tsetupfee\":\"0.00\",\"monthly\":\"53.60\",\"quarterly\":\"134.01\",\"semiannually\":\"0.00\",\"annually\":\"0.00\",\"biennially\":\"0.00\",\"triennially\":\"0.00\"},\"USD\":{\"msetupfee\":\"64.79\",\"qsetupfee\":\"0.00\",\"ssetupfee\":\"0.00\",\"asetupfee\":\"0.00\",\"bsetupfee\":\"0.00\",\"tsetupfee\":\"0.00\",\"monthly\":\"57.59\",\"quarterly\":\"143.97\",\"semiannually\":\"0.00\",\"annually\":\"0.00\",\"biennially\":\"0.00\",\"triennially\":\"0.00\"}}}]}}]}}]}}";

        static void Main()
        {
            var whmcs = new WhmcsApi("CSharpAPI", "1FabTester!", "whmcsdev.fab-it.dk/shop", true, new DataStore());


            var results = whmcs.GetProductsByProductId(98);
            Console.WriteLine(results);

            var results2 = whmcs.GetClientDetailsByClientId(81);
            Console.WriteLine(results2);

            var results3 = whmcs.temp();
            getPrintableVersion(results3);
            
            var tmp = @" Hello=""There"" ";
            var tmp2 = " Hello= \"There\" ";
            Console.WriteLine(tmp + " : " + tmp2 );
            //Console.ReadKey();



            var tmp3 = whmcs.GetDataTemp();
            var newtmp3 = JsonConvert.DeserializeObject<ProductsResponse>(RawJsonProducts);
            Console.WriteLine(tmp3);
        }

        private static void getPrintableVersion(byte[] results)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = path + @"\test.txt";

            
            var tmp = JsonConvert.DeserializeObject<Dictionary<string, object>>(Encoding.UTF8.GetString(results));

            System.IO.File.WriteAllText(filePath, JsonConvert.SerializeObject(tmp.ToArray(), Formatting.Indented));
            System.Diagnostics.Process.Start(filePath);
        }
    }
}
