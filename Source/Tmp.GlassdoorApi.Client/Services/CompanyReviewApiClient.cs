using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tmp.GlassdoorApi.Client.Models;

namespace Tmp.GlassdoorApi.Client
{
    public class CompanyReviewApiClient: ICompanyReviewApiClient
    {
        private IBaseApiClient _baseApiClient;

        public CompanyReviewApiClient(IBaseApiClient baseApiClient)
        {
            _baseApiClient = baseApiClient;
        }

        public Task<CompanyReviewResponse> GetCompanyReview(int companyId)
        {
            var client = _baseApiClient.GetClient();
            var result = client.GetCompanyReviewAsync(companyId);

            return result;
        }
    }
}
