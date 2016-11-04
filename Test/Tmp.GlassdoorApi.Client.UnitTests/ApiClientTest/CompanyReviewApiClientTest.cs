using System;
using Moq;
using Microsoft.Practices.ServiceLocation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tmp.GlassdoorApi.Client.UnitTests
{
    [TestClass]
    public class CompanyReviewApiClientTest
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
            var api = new GlassdoorApiConfiguration(GlassdoorApiParams.BaseUrl,
                GlassdoorApiParams.PartnerId,
                GlassdoorApiParams.ApiKey,
                GlassdoorApiParams.Vesrion,
                GlassdoorApiParams.Format,
                GlassdoorApiParams.UserIP,
                GlassdoorApiParams.UserAgent);

            _baseApiClient.Setup(x => x.GetClient()).Returns(api);

            var apiClient = new CompanyReviewApiClient(_baseApiClient.Object);

            var task = apiClient.GetCompanyReview(12);

            var response = task.Result;

            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success == true);
            Assert.IsNotNull(response.Result);
        }
    }
}
