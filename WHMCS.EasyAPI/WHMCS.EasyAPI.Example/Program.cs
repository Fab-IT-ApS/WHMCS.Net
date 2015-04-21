using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using WHMCS.EasyAPI.DataStores;

namespace WHMCS.EasyAPI.Example
{
    class Program
    {
        static void Main()
        {
            var dataStore = new DataStore();
            var whmcs = new WhmcsApi("CSharpAPI", "1FabTester!", "whmcsdev.fab-it.dk/shop", true, dataStore);


            var results = whmcs.GetClientDetails(81);
            Console.WriteLine(results);

            var results2 = whmcs.GetClientDetails(81);
            Console.WriteLine(results2);

            var results3 = whmcs.temp(81);
            getPrintableVersion(results3);
            
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
