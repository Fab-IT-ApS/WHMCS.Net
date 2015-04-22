using System;
using System.Collections.Specialized;
using System.Net;
using Newtonsoft.Json;
using Whmcs.Converters;
using Whmcs.Interfaces;
using Whmcs.Model.ClientDetails;
using Whmcs.Model.Clients;
using Whmcs.Model.Products;

namespace Whmcs
{
    public class WhmcsApi
    {
        private readonly string username;
        private readonly string password;
        private readonly string url;
        private readonly IDataStore dataStore;
        private readonly NameValueCollection formData;
        private readonly MD5Converter md5Converter = new MD5Converter();

        public WhmcsApi(string username, string password, string domain, bool secure, IDataStore dataStore)
        {
            this.username = username;
            this.password = md5Converter.ToMD5(password);
            this.dataStore = dataStore;
            url = (secure ? "https://" : "http://") + domain + "/includes/api.php";

            formData = new NameValueCollection()
            {
                {"username", this.username},
                {"password", this.password},
                {"responsetype", "json"}
            };
        }

        public ProductsResponse GetProducts()
        {
            return JsonConvert.DeserializeObject<ProductsResponse>(dataStore.GetData(url, new NameValueCollection
            {
                formData,
                {"action", "getproducts"}
            }));
        }
        public ProductsResponse GetProductsByProductID(int productId)
        {
            return JsonConvert.DeserializeObject<ProductsResponse>(dataStore.GetData(url, new NameValueCollection
            {
                formData,
                {"action", "getproducts"},
                {"pid", productId.ToString()}
            }));
        }
        public ProductsResponse GetProductsByGroupID(int groupId)
        {
            return JsonConvert.DeserializeObject<ProductsResponse>(dataStore.GetData(url, new NameValueCollection
            {
                formData,
                {"action", "getproducts"},
                {"gid", groupId.ToString()}
            }));
        }
        public ProductsResponse GetProductsByModuleName(string moduleName)
        {
            return JsonConvert.DeserializeObject<ProductsResponse>(dataStore.GetData(url, new NameValueCollection
            {
                formData,
                {"action", "getproducts"},
                {"module", moduleName}
            }));
        }

        public ClientsResponse GetClients()
        {
            return JsonConvert.DeserializeObject<ClientsResponse>(dataStore.GetData(url, new NameValueCollection
            {
                formData,
                {"action", "getclients"},
                {"limitstart","0"}, // Default Value in API
                {"limitnum","25"} // Default Value in API
            }));
        }
        public ClientsResponse SearchClients(string searchableArguement)
        {
            return JsonConvert.DeserializeObject<ClientsResponse>(dataStore.GetData(url, new NameValueCollection
            {
                formData,
                {"action", "getclients"},
                {"limitstart", "0"}, // Default Value in API
                {"limitnum", "25"}, // Default Value in API
                {"search", searchableArguement}
            }));
        }

        public ClientDetailsResponse GetClientDetails(int clientId, bool stats = true)
        {
            return JsonConvert.DeserializeObject<ClientDetailsResponse>(dataStore.GetData(url, new NameValueCollection
            {
                formData,
                {"action", "getclientsdetails"},
                {"clientid", clientId.ToString()},
                {"stats", stats.ToString()}
            }));
        }
        public ClientDetailsResponse GetClientDetails(string emailAddress, bool stats = true)
        {
            return JsonConvert.DeserializeObject<ClientDetailsResponse>(dataStore.GetData(url, new NameValueCollection
            {
                formData,
                {"action", "getclientsdetails"},
                {"email", emailAddress},
                {"stats", stats.ToString()}
            }));
        }





        public Byte[] temp()
        {
            NameValueCollection requestData = new NameValueCollection
            {
                formData,
                {"action", "getproducts"},
                {"pid", "65"}
            };
            return new WebClient().UploadValues(url, requestData);
        }

    }
}
