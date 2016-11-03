using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tmp.GlassdoorApi.Client.Models;

namespace Tmp.GlassdoorApi.Client
{
    public class CompanyRatingApiClient: ICompanyRatingApiClient
    {
        private IBaseApiClient _baseApiClient;

        public CompanyRatingApiClient(IBaseApiClient baseApiClient)
        {
            _baseApiClient = baseApiClient;
        }

        public Task<CompanyRatingResponse> GetCompanyRatingsAsync(int companyId)
        {
            var client = _baseApiClient.GetClient();
            var result = client.GetCompanyRatingsAsync(companyId);

            return result;
        }
    }
}
