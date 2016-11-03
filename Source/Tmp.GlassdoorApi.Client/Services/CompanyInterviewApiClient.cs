using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tmp.GlassdoorApi.Client.Models;

namespace Tmp.GlassdoorApi.Client
{
    public class CompanyInterviewApiClient: ICompanyInterviewApiClient
    {
        private IBaseApiClient _baseApiClient;

        public CompanyInterviewApiClient(IBaseApiClient baseApiClient)
        {
            _baseApiClient = baseApiClient;
        }

        public Task<CompanyInterviewResponse> GetCompanyInterviewsAsync(int companyId,
            string jobTitle = "",
            string companyName = "",
            string ticker = "",
            bool? includeReviewText = null)
        {
            var client = _baseApiClient.GetClient();
            var result = client.GetCompanyInterviewsAsync(companyId,
                jobTitle,
                companyName,
                ticker,
                includeReviewText);

            return result;
        }

    }
}
