using System.Collections.Specialized;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Whmcs.DataStores;
using Whmcs.Tests.Testables;

namespace Whmcs.Tests
{
    [TestClass]
    public class TestProducts
    {
        private WhmcsApi whmcsApi;
        private TestableDataStore testableDataStore;

        [TestInitialize]
        public void TestInitialize()
        {
            testableDataStore = new TestableDataStore();
            whmcsApi = new WhmcsApi("x", "y", "z", true, testableDataStore);
        }

        [TestMethod]
        public void Test()
        {
            //Arrange

            //Act
            var results = whmcsApi.GetProducts();

            //Assert
            Assert.AreEqual(65, results.Products.Product.FirstOrDefault().ProductId); 
        }
    }
}
