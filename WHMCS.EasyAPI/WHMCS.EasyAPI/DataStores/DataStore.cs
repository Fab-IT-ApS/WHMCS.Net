using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using WHMCS.EasyAPI.Interfaces;

namespace WHMCS.EasyAPI.DataStores
{
    public class DataStore : IDataStore
    {
        public string GetData(string url, NameValueCollection values)
        {
            try
            {
                byte[] webResponse = new WebClient().UploadValues(url, values);
                return Encoding.ASCII.GetString(webResponse);
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to connect to WHMCS API. " + ex.Message);
            }
        }
    }
}
