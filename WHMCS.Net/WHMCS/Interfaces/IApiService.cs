
using System.Collections.Specialized;

namespace WHMCS.Interfaces
{
    public interface IApiService
    {
        void InitializeApi(string username, string password, string domain, bool secure);
        string GetData(NameValueCollection values);
    }
}
