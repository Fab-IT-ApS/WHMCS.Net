using System.Collections.Specialized;
using System.IO;
using Whmcs.Interfaces;
using Whmcs.Tests.TestableData;

namespace Whmcs.Tests.Testables
{
    public class TestableDataStore : IDataStore
    {
        private readonly GetTestData rawJson = new GetTestData();

        public string GetData(string url, NameValueCollection values)
        {
            return rawJson.RawJsonProducts;
        }
    }
}
