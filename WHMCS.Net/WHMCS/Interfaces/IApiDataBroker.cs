using WHMCS.Model.ClientDetails;
using WHMCS.Model.Clients;
using WHMCS.Model.Products;

namespace WHMCS.Interfaces
{
    public interface IApiDataBroker
    {
        ProductsResponse GetProducts();
        ProductsResponse GetProductsByProductId(int productId);
        ProductsResponse GetProductsByGroupId(int groupId);
        ProductsResponse GetProductsByModuleName(string moduleName);

        ClientsResponse GetClients(int limitStart = 0, int limitNum = 25);
        ClientsResponse GetClientsByEmail(string searchArg, int limitStart = 0, int limitNum = 25);

        ClientDetailsResponse GetClientDetailsByClientId(int clientId, bool stats = true);
        ClientDetailsResponse GetClientDetailsByEmail(string emailAddress, bool stats = true);

        
    }
}
