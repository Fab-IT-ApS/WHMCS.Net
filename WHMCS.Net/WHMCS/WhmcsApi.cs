using WHMCS.Interfaces;
using WHMCS.Model.ClientDetails;
using WHMCS.Model.Clients;
using WHMCS.Model.Products;

namespace WHMCS
{
    public class WhmcsApi : IApiDataBroker
    {
        private readonly IApiDataBroker dataBroker;

        public WhmcsApi(IApiDataBroker dataBroker)
        {
            this.dataBroker = dataBroker;
        }

        public ProductsResponse GetProducts()
        {
            return dataBroker.GetProducts();
        }
        public ProductsResponse GetProductsByProductId(int productId)
        {
            return dataBroker.GetProductsByProductId(productId);
        }
        public ProductsResponse GetProductsByGroupId(int groupId)
        {
            return dataBroker.GetProductsByGroupId(groupId);
        }
        public ProductsResponse GetProductsByModuleName(string moduleName)
        {
            return dataBroker.GetProductsByModuleName(moduleName);
        }

        public ClientsResponse GetClients(int limitStart = 0, int limitNum = 25)
        {
            return dataBroker.GetClients(limitStart, limitNum);
        }
        public ClientsResponse GetClientsByEmail(string searchArg, int limitStart = 0, int limitNum = 25)
        {
            return dataBroker.GetClientsByEmail(searchArg, limitStart, limitNum);
        }

        public ClientDetailsResponse GetClientDetailsByClientId(int clientId, bool stats = true)
        {
            return dataBroker.GetClientDetailsByClientId(clientId, stats);
        }
        public ClientDetailsResponse GetClientDetailsByEmail(string emailAddress, bool stats = true)
        {
            return dataBroker.GetClientDetailsByEmail(emailAddress, stats);
        }
    }
}
