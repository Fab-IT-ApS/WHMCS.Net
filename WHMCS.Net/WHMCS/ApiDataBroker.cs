using System.Collections.Specialized;
using WHMCS.Interfaces;
using WHMCS.Model.ClientDetails;
using WHMCS.Model.Clients;
using WHMCS.Model.ClientsProducts;
using WHMCS.Model.Contacts;
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

        public ClientsResponse GetClients(int limitStart = 0, int limitNum = 25)
        {
            var inputData = new NameValueCollection
            {
                {"action", "getclients"},
                {"limitstart",limitStart.ToString()},
                {"limitnum",limitNum.ToString()}
            };

            var apiResponse = apiService.GetData(inputData);
            return jsonService.DeserializeJSON<ClientsResponse>(apiResponse);
        }
        public ClientsResponse GetClientsByEmail(string searchArg, int limitStart = 0, int limitNum = 25)
        {
            var inputData = new NameValueCollection
            {
                {"action", "getclients"},
                {"limitstart",limitStart.ToString()},
                {"limitnum",limitNum.ToString()},
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

        public ContactsResponse GetContacts(int limitStart = 0, int limitNum = 25)
        {
            var inputData = new NameValueCollection
            {
                {"action", "getcontacts"},
                {"limitstart",limitStart.ToString()},
                {"limitnum",limitNum.ToString()}
            };

            var apiResponse = apiService.GetData(inputData);
            return jsonService.DeserializeJSON<ContactsResponse>(apiResponse);
        }

        public ContactsResponse GetContactsByClientId(int clientId, int limitStart = 0, int limitNum = 100)
        {
            var inputData = new NameValueCollection
            {
                {"action", "getcontacts"},
                {"userid", clientId.ToString()},
                {"limitstart", limitStart.ToString()},
                {"limitnum", limitNum.ToString()}
            };

            var apiResponse = apiService.GetData(inputData);
            return jsonService.DeserializeJSON<ContactsResponse>(apiResponse);
        }

        public ClientsProductsResponse GetClientProducts(int clientId)
        {
            var inputData = new NameValueCollection
            {
                {"action", "getclientsproducts"},
                {"clientid", clientId.ToString()},
            };

            var apiResponse = apiService.GetData(inputData);
            return jsonService.DeserializeJSON<ClientsProductsResponse>(apiResponse);
        }

        public string GetRawJSON(NameValueCollection inputData)
        {
            return apiService.GetData(inputData);
        }
    }
}
