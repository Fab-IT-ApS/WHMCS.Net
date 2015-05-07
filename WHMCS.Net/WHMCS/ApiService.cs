using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using WHMCS.Converters;
using WHMCS.Interfaces;

namespace WHMCS
{
    public class ApiService : IApiService
    {
        private string url;
        private NameValueCollection apiCredentials;

        public ApiService(string username, string password, string domain, bool secure)
        {
            this.InitializeApi(username, password, domain, secure);
        }
        
        public void InitializeApi(string username, string password, string domain, bool secure)
        {
            var converter = new MD5Converter();
            apiCredentials = new NameValueCollection
            {
                {"username", username},
                {"password", converter.ToMD5(password)},
                {"responsetype", "json"}
            };
            url = (secure ? "https://" : "http://") + domain + "/includes/api.php";
        }

        public string GetData(NameValueCollection values)
        {
            var serverRequest = new NameValueCollection
            {
                apiCredentials,
                values
            };

            try
            {
                var webResponse = new WebClient().UploadValues(url, serverRequest);
                return Encoding.ASCII.GetString(webResponse);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("403"))
                {
                    throw new Exception("Unable to connect to WHMCS API: Wrong username or password. Access Denied.", ex);
                }

                if (ex.Message.Contains("404"))
                {
                    throw new Exception("Unable to connect to: " + url + ".", ex);
                }

                throw new Exception("Unable to connect to WHMCS API. " + ex.Message);
            }
        }
    }
}
