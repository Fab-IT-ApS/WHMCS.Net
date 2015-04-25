using System.Collections.Specialized;
using System.Net;
using System.Text;
using Whmcs.Exception;
using Whmcs.Interfaces;

namespace Whmcs.DataStores
{
    public class DataStore : IDataStore
    {
        public string GetData(string url, NameValueCollection values)
        {
            try
            {
                var webResponse = new WebClient().UploadValues(url, values);
                return Encoding.ASCII.GetString(webResponse);
            }
            catch (System.Exception ex)
            {
                if (ex.Message.Contains("403"))
                {
                    throw new ApiConnectionFailedException("Unable to connect to WHMCS API: Wrong username or password. Access Denied.", ex);
                }
                else if (ex.Message.Contains("404"))          
                {
                    throw new ApiConnectionFailedException("Unable to connect to: " + url + ".", ex);
                }
                else
                {
                    throw new ApiConnectionFailedException("Unable to connect to WHMCS API. " + ex.Message);
                }
            }
        }
    }
}
