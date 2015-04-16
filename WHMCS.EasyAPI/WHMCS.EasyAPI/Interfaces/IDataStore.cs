using System.Collections.Specialized;

namespace WHMCS.EasyAPI.Interfaces
{
    public interface IDataStore
    {
        string GetData(string url, NameValueCollection values);
    }
}
