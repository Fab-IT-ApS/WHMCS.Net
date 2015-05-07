using System;
using System.IO;
using System.Linq.Expressions;
using Whmcs.Interfaces;

namespace Whmcs.Example
{
    class Program
    {   
        static void Main()
        {
            const string path = @"C:\Git\config files\whmcs.txt";
            var username = GetLine(path, 1); // string
            var password = GetLine(path, 2); // string
            var domain = GetLine(path, 3); // string - ex: MyWhmcs.Installation.net
            var secure = GetLine(path, 4); // bool - true = https, false = http


            IApiService apiService = new ApiService(username, password, domain, bool.Parse(secure));
            IJSONService jsonService = new JSONService();
            IApiDataBroker apiDataBroker = new ApiDataBroker(apiService, jsonService);

            var whmcsApi = new WhmcsApi(apiDataBroker);
            var tmp = whmcsApi.GetProducts();
            Console.WriteLine(tmp);

        }

        private static string GetLine(string fileName, int line)
        {
            using (var sr = new StreamReader(fileName))
            {
                for (int i = 1; i < line; i++)
                    sr.ReadLine();
                return sr.ReadLine();
            }
        }
    }
}
