﻿using System;
using System.Collections.Specialized;
using System.Net;
using Newtonsoft.Json;
using WHMCS.EasyAPI.Converters;
using WHMCS.EasyAPI.Model.Products;
using WHMCS.EasyAPI.Interfaces;
using WHMCS.EasyAPI.Model.Clients;

namespace WHMCS.EasyAPI
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


        public Byte[] temp(int id)
        {
            NameValueCollection requestData = new NameValueCollection
            {
                formData,
                {"action", "getclientsdetails"},
                {"clientid", id.ToString()},
                {"stats", true.ToString()}
            };
            return new WebClient().UploadValues(url, requestData);
        }

    }
}
