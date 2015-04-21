using System.Collections.Specialized;

namespace Whmcs.Interfaces
{
    public interface IDataStore
    {
        string GetData(string url, NameValueCollection values);
    }
}
