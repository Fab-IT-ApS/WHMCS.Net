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

            var results = whmcs.SearchClients("Jannie");
            Console.WriteLine(results);

            var results2 = whmcs.temp(81);
            getPrintableVersion(results2);
            
        }

        private static void getPrintableVersion(byte[] results)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string FilePath = path + @"\test.txt";

            
            var tmp = JsonConvert.DeserializeObject<Dictionary<string, object>>(Encoding.UTF8.GetString(results));
            
            System.IO.File.WriteAllText(FilePath, JsonConvert.SerializeObject(tmp.ToArray(), Formatting.Indented));
            System.Diagnostics.Process.Start(FilePath);
        }
    }
}
