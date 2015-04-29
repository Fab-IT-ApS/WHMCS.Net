using Whmcs.Interfaces;
using Whmcs.Model.Products;

namespace Whmcs
{
    public class WhmcsApi
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
    }
}
