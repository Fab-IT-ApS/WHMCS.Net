using System.Collections.Specialized;
using Moq;
using NUnit.Framework;
using Whmcs.Interfaces;

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
            var actualResult = dataBroker.GetProductsByProductId(testProductId);

            // Assert
            mockApiService.Verify(a => a.GetData(expectedJSON));
        }
    }
}
