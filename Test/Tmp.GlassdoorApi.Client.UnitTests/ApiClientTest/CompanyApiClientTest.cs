using System;
using Moq;
using Microsoft.Practices.ServiceLocation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tmp.GlassdoorApi.Client.UnitTests
{
    [TestClass]
    public class CompanyApiClientTest
    {
        protected readonly Mock<IServiceLocator> _serviceLocator = new Mock<IServiceLocator>();
        protected readonly Mock<IBaseApiClient> _baseApiClient = new Mock<IBaseApiClient>();

        [TestInitialize]
        public void TestInit()
        {
            _serviceLocator.Setup(s => s.GetInstance(typeof(IBaseApiClient), It.IsAny<string>())).Returns(_baseApiClient.Object);
        }

        //since it is connecting to the real api configuration with limited call times, temp ignore it
        [Ignore]
        [TestMethod]
        public void GetCompaniesAsyncTestMethod()
        {
            var client = new GlassdoorApiConfiguration(API.baseUrl, API.partnerId, API.apiKey);

            _baseApiClient.Setup(x => x.GetClient()).Returns(client);

            var apiClient = new CompanyApiClient(_baseApiClient.Object);

            try
            {
                var task = apiClient.GetCompaniesAsync("abc");
                //task.Wait();
                var response = task.Result;
                
                Assert.IsTrue(response?.Success == true);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
        }
    }
}
