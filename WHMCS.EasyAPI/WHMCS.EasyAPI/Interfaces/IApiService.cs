
using System.Collections.Specialized;

namespace Whmcs.Interfaces
{
    public interface IApiService
    {
        void InitializeApi(string username, string password, string domain, bool secure);
        string GetData(NameValueCollection values);
    }
}
