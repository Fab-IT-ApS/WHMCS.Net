using System;
using System.Collections.Specialized;
using WHMCS.Interfaces;
using WHMCS.Model.ClientDetails;
using WHMCS.Model.Clients;
using WHMCS.Model.Products;

namespace WHMCS
{
    public class ApiDataBroker : IApiDataBroker
    {
        private readonly IApiService apiService;
        private readonly IJSONService jsonService;

        public ApiDataBroker(IApiService apiService, IJSONService jsonService)
        {
            this.apiService = apiService;
            this.jsonService = jsonService;
        }

        public ProductsResponse GetProducts()
        {
            var inputData = new NameValueCollection
            {
                {"action", "getproducts"}
            };

            var apiResponse = apiService.GetData(inputData);
            return jsonService.DeserializeJSON<ProductsResponse>(apiResponse);
        }
        public ProductsResponse GetProductsByProductId(int productId)
        {
            var inputData = new NameValueCollection
            {
                {"action", "getproducts"},
                {"pid", productId.ToString()}
            };

            var apiResponse = apiService.GetData(inputData);
            return jsonService.DeserializeJSON<ProductsResponse>(apiResponse);
        }
        public ProductsResponse GetProductsByGroupId(int groupId)
        {
            var inputData = new NameValueCollection
            {
                {"action", "getproducts"},
                {"gid", groupId.ToString()}
            };

            var apiResponse = apiService.GetData(inputData);
            return jsonService.DeserializeJSON<ProductsResponse>(apiResponse);
        }
        public ProductsResponse GetProductsByModuleName(string moduleName)
        {
            var inputData = new NameValueCollection
            {
                {"action", "getproducts"},
                {"module", moduleName}
            };

            var apiResponse = apiService.GetData(inputData);
            return jsonService.DeserializeJSON<ProductsResponse>(apiResponse);
        }

        public ClientsResponse GetClients()
        {
            var inputData = new NameValueCollection
            {
                {"action", "getclients"},
                {"limitstart","0"}, // Default Value in API = 0
                {"limitnum","999"} // Default Value in API = 25
            };

            var apiResponse = apiService.GetData(inputData);
            return jsonService.DeserializeJSON<ClientsResponse>(apiResponse);
        }
        public ClientsResponse SearchClientsByEmail(string searchArg)
        {
            var inputData = new NameValueCollection
            {
                {"action", "getclients"},
                {"limitstart", "0"}, // Default Value in API
                {"limitnum", "25"}, // Default Value in API
                {"search", searchArg}
            };

            var apiResponse = apiService.GetData(inputData);
            return jsonService.DeserializeJSON<ClientsResponse>(apiResponse);
        }

        public ClientDetailsResponse GetClientDetailsByClientId(int clientId, bool stats = true)
        {
            var inputData = new NameValueCollection
            {
                {"action", "getclientsdetails"},
                {"clientid", clientId.ToString()},
                {"stats", stats.ToString()}
            };

            var apiResponse = apiService.GetData(inputData);
            return jsonService.DeserializeJSON<ClientDetailsResponse>(apiResponse);
        }
        public ClientDetailsResponse GetClientDetailsByEmail(string emailAddress, bool stats = true)
        {
            var inputData = new NameValueCollection
            {
                {"action", "getclientsdetails"},
                {"email", emailAddress},
                {"stats", stats.ToString()}
            };

            var apiResponse = apiService.GetData(inputData);
            return jsonService.DeserializeJSON<ClientDetailsResponse>(apiResponse);
        }
    }
}
