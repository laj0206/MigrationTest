using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tmp.GlassdoorApi.Client.Models;

namespace Tmp.GlassdoorApi.Client
{
    public class CompanyOverviewApiClient: ICompanyOverviewApiClient
    {
        private IBaseApiClient _baseApiClient;

        public CompanyOverviewApiClient(IBaseApiClient baseApiClient)
        {
            _baseApiClient = baseApiClient;
        }

        public Task<CompanyOverviewResponse> GetCompanyOverviewsAsync(int companyId)
        {
            var client = _baseApiClient.GetClient();
            var result = client.GetCompanyOverviewsAsync(companyId);

            return result;
        }
    }
}
