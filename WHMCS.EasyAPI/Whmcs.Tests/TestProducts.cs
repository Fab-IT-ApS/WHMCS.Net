using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Whmcs.Tests.Testables;

namespace Whmcs.Tests
{
    [TestClass]
    public class TestProducts
    {
        private WhmcsApi whmcsApi;

        [TestInitialize]
        public void TestInitialize()
        {
            whmcsApi = new WhmcsApi("X", "Y", "Z", true, new TestableDataStore());
        }

        [TestMethod]
        public void TestGetProdctByProductId()
        {
            var results = whmcsApi.GetProductsByProductId(98);
            Assert.AreEqual(98, results.Products.Product.FirstOrDefault().ProductId);
        }

        [TestMethod]
        public void TestGetProductByGroupId()
        {
            var results = whmcsApi.GetProductsByGroupId(25);
            Assert.AreEqual(25, results.Products.Product.FirstOrDefault().GroupId);
        }

        [TestMethod]
        public void TestGetProducts()
        {
            var results = whmcsApi.GetProducts();
            Assert.AreEqual(98, results.Products.Product.FirstOrDefault().ProductId);
        }
    }
}
