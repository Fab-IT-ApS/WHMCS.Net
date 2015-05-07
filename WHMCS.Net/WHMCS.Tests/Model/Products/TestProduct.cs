using Moq;
using NUnit.Framework;
using WHMCS.Interfaces;
using WHMCS.Model.Products;

namespace WHMCS.Tests.Model.Products
{
    [TestFixture]
    public class TestProduct
    {
        [Test]
        public void GetProducts_DataBrokerResults()
        {
            // Arrange
            var expectedResult = new ProductsResponse();
            var mockDataBroker = new Mock<IApiDataBroker>();

            mockDataBroker.Setup(d => d.GetProducts()).Returns(expectedResult).Verifiable();
            var whmcsApi = new WhmcsApi(mockDataBroker.Object);

            // Act
            var actualResult = whmcsApi.GetProducts();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
            mockDataBroker.Verify();
        }

        [Test]
        public void GetProductsByProductId_DataBrokerResults()
        {
            // Arrange
            const int inputProductId = 1;
            var expectedResult = new ProductsResponse();
            var mockDataBroker = new Mock<IApiDataBroker>();

            mockDataBroker.Setup(d => d.GetProductsByProductId(inputProductId)).Returns(expectedResult).Verifiable();
            var whmcsApi = new WhmcsApi(mockDataBroker.Object);

            // Act
            var actualResult = whmcsApi.GetProductsByProductId(inputProductId);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
            mockDataBroker.Verify();
        }

        [Test]
        public void GetProductsByGroupId_DataBrokerResults()
        {
            // Arrange
            const int inputGroupId = 1;
            var expectedResult = new ProductsResponse();
            var mockDataBroker = new Mock<IApiDataBroker>();

            mockDataBroker.Setup(d => d.GetProductsByGroupId(inputGroupId)).Returns(expectedResult).Verifiable();
            var whmcsApi = new WhmcsApi(mockDataBroker.Object);

            // Act
            var actualResult = whmcsApi.GetProductsByGroupId(inputGroupId);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
            mockDataBroker.Verify();
        }

        [Test]
        public void GetProductsByModuleName_DataBrokerResults()
        {
            // Arrange
            const string inputModuleName = "SomeModule";
            var expectedResult = new ProductsResponse();
            var mockDataBroker = new Mock<IApiDataBroker>();

            mockDataBroker.Setup(d => d.GetProductsByModuleName(inputModuleName)).Returns(expectedResult).Verifiable();
            var whmcsApi = new WhmcsApi(mockDataBroker.Object);

            // Act
            var actualResult = whmcsApi.GetProductsByModuleName(inputModuleName);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
            mockDataBroker.Verify();
        }
    }
}
