﻿using System.Collections.Specialized;
using System.Linq.Expressions;
using Moq;
using NUnit.Framework;
using Whmcs.Interfaces;
using Whmcs.Model.Products;

namespace Whmcs.Tests
{
    [TestFixture]
    public class TestApiDataBroker
    {
        [Test]
        public void GetProductsByProductId_CallApiService()
        {
            // Arrange
            const int testProductId = 1;
            const string testOutputApiResponse = "testresponse";
            var expectedJSON = new NameValueCollection
            {
                {"action", "getproducts"},
                {"pid", testProductId.ToString()}
            };

            var mockApiService = new Mock<IApiService>();
            mockApiService.Setup(a => a.GetData(expectedJSON)).Returns(testOutputApiResponse).Verifiable();

            var mockJSONService = new Mock<IJSONService>();
            var dataBroker = new ApiDataBroker(mockApiService.Object, mockJSONService.Object);

            // Act
            dataBroker.GetProductsByProductId(testProductId);
            
            // Assert
            mockApiService.Verify(a => a.GetData(expectedJSON));
        }

        [Test]
        public void GetProductsByProductId()
        {
            // Arrange
            const int testProductId = 1;
            const string testOutputApiResponse = "testresponse";
            var testJSON = new NameValueCollection {{"test", "test"}};
            var expectedResult = new ProductsResponse();

            var mockApiService = new Mock<IApiService>();
            mockApiService.Setup(a => a.GetData(testJSON)).Returns(testOutputApiResponse).Verifiable();

            var mockJSONService = new Mock<IJSONService>();
            mockJSONService.Setup(j => j.DeserializeJSON<ProductsResponse>(It.IsAny<string>())).Returns(expectedResult);

            var dataBroker = new ApiDataBroker(mockApiService.Object, mockJSONService.Object);

            // Act
            var actualResult = dataBroker.GetProductsByProductId(testProductId);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
            mockJSONService.Verify(j => j.DeserializeJSON<ProductsResponse>(It.IsAny<string>()));
        }
    }
}
