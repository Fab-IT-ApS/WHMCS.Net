using System;
using System.Collections.Specialized;
using Whmcs.Interfaces;
using Whmcs.Model.ClientDetails;
using Whmcs.Model.Clients;
using Whmcs.Model.Products;

namespace Whmcs
{
    class ApiDataBroker : IApiDataBroker
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
            throw new NotImplementedException();
        }
        public ProductsResponse GetProductsByGroupId(int groupId)
        {
            throw new NotImplementedException();
        }
        public ProductsResponse GetProductsByModuleName(string moduleName)
        {
            throw new NotImplementedException();
        }

        public ClientsResponse GetClients()
        {
            throw new NotImplementedException();
        }
        public ClientsResponse SearchClientsByEmail(string searchArg)
        {
            throw new NotImplementedException();
        }

        public ClientDetailsResponse GetClientDetailsByClientId(int clientId, bool stats = true)
        {
            throw new NotImplementedException();
        }
        public ClientDetailsResponse GetClientDetailsByEmail(string emailAddress, bool stats = true)
        {
            throw new NotImplementedException();
        }
    }
}
