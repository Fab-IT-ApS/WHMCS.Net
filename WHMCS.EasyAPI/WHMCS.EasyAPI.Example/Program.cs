using System;
using Whmcs.Interfaces;
using System.Configuration;

namespace Whmcs.Example
{
    class Program
    {   
        static void Main()
        {
            IApiService apiService = new ApiService(
                ConfigurationManager.AppSettings["Username"],
                ConfigurationManager.AppSettings["Password"],
                ConfigurationManager.AppSettings["Domain"], 
                Boolean.Parse(ConfigurationManager.AppSettings["Secure"]));

            IJSONService jsonService = new JSONService();


            IApiDataBroker apiDataBroker = new ApiDataBroker(apiService, jsonService);

            var whmcsApi = new WhmcsApi(apiDataBroker);
            var tmp = whmcsApi.GetProducts();
            Console.WriteLine(tmp);

        }
    }
}
