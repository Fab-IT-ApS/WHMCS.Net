using System.Collections.Generic;
using System.Collections.Specialized;
using Whmcs.Interfaces;
using Whmcs.Tests.TestableData;

namespace Whmcs.Tests.Testables
{
    public class TestableDataStore : IDataStore
    {
        private readonly GetTestData rawJson = new GetTestData();
        private readonly Dictionary<string, string> json;

        public string GetData(string url, NameValueCollection values)
        {
            return json[values["action"]];
        }

        public TestableDataStore()
        {
            json = new Dictionary<string, string>();

            json["getproducts"] = rawJson.Products;
            json["getclients"] = rawJson.Clients;
            json["getclientsdetails"] = rawJson.ClientDetails;
        }

    }
}
