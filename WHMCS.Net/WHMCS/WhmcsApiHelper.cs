using WHMCS.Interfaces;

namespace WHMCS
{
    public class WhmcsApiHelper
    {
        public readonly WhmcsApi Api;

        public WhmcsApiHelper(string username, string password, string domain, bool secure = true)
        {
            IApiService apiService = new ApiService(username, password, domain, secure);
            IApiDataBroker apiDataBroker = new ApiDataBroker(apiService, new JSONService());

            Api = new WhmcsApi(apiDataBroker);
        }


    }
}
