using Microsoft.VisualStudio.TestTools.UnitTesting;
using Whmcs.DataStores;
using Whmcs.Exception;

namespace Whmcs.Tests
{
    [TestClass]
    public class TestConnection
    {
        private WhmcsApi whmcsApi;

        [TestMethod]
        [ExpectedException(typeof(ApiConnectionFailedException))]
        public void TestWrongConnectionValues()
        {
            whmcsApi = new WhmcsApi("Username", "Password", "Domain.tld", true, new DataStore());
            whmcsApi.GetProducts();
        }
    }
}
