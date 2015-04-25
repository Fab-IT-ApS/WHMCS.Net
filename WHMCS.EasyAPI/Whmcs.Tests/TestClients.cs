using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Whmcs.Tests.Testables;

namespace Whmcs.Tests
{
    [TestClass]
    public class TestClients
    {
        private WhmcsApi whmcsApi;

        [TestInitialize]
        public void TestInitialize()
        {
            whmcsApi = new WhmcsApi("X", "Y", "Z", true, new TestableDataStore());
        }

        [TestMethod]
        public void TestGetClients()
        {
            var results = whmcsApi.GetClients();
            Assert.AreEqual(88, results.Clients.Client.FirstOrDefault().ClientId);
        }

        [TestMethod]
        public void TestSearchClients()
        {
            var results = whmcsApi.SearchClientsByEmail("Data Returned is Fixed");
            Assert.AreEqual(88, results.Clients.Client.FirstOrDefault().ClientId);
        }
    }
}
