using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tmp.GlassdoorApi.Client.Models;

namespace Tmp.GlassdoorApi.Client
{
    public class CompanyApiClient : ICompanyApiClient
    {
        private IBaseApiClient _baseApiClient;

        public CompanyApiClient(IBaseApiClient baseApiClient)
        {
            _baseApiClient = baseApiClient;
        }

        public Task<CompanySearchResponse> GetCompaniesAsync(string companyName = "",
            string location = "",
            string city = "",
            string state = "",
            string country = "")
        {
            var client = _baseApiClient.GetClient();
            var result = client.GetCompaniesAsync(companyName, 
                location,
                city,
                state,
                country);

            return result;
        }

        
    }
}
