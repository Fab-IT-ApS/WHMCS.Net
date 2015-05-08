using System.Collections.Specialized;
using WHMCS.Model.ClientDetails;
using WHMCS.Model.Clients;
using WHMCS.Model.Contacts;
using WHMCS.Model.Products;

namespace WHMCS.Interfaces
{
    public interface IApiDataBroker
    {
        ProductsResponse GetProducts();
        ProductsResponse GetProductsByProductId(int productId);
        ProductsResponse GetProductsByGroupId(int groupId);
        ProductsResponse GetProductsByModuleName(string moduleName);

        ClientsResponse GetClients(int limitStart = 0, int limitNum = 100);
        ClientsResponse GetClientsByEmail(string searchArg, int limitStart = 0, int limitNum = 100);

        ClientDetailsResponse GetClientDetailsByClientId(int clientId, bool stats = true);
        ClientDetailsResponse GetClientDetailsByEmail(string emailAddress, bool stats = true);

        ContactsResponse GetContacts(int limitStart = 0, int limitNum = 100);
        ContactsResponse GetContactsByClientId(int clientId, int limitStart = 0, int limitNum = 100);

        string GetRawJSON(NameValueCollection inputData);
    }
}
