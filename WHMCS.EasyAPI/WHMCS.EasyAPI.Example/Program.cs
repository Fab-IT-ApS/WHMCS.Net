using System;
using Whmcs.Interfaces;

namespace Whmcs.Example
{
    class Program
    {   
        static void Main()
        {
            IApiService apiService = new ApiService("CSharpAPI", "1FabTester!", "whmcsdev.fab-it.dk/shop/", true);
            IJSONService jsonService = new JSONSerivce();


            IApiDataBroker apiDataBroker = new ApiDataBroker(apiService, jsonService);

            var WhmcsApi = new WhmcsApi(apiDataBroker);
            var tmp = WhmcsApi.GetProducts();
            Console.WriteLine(tmp);

        }
    }
}
