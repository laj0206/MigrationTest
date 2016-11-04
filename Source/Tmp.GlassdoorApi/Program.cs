using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tmp.GlassdoorApi.Client;
using Microsoft.Practices.ServiceLocation;

namespace Tmp.GlassdoorApi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Glassdoor API set up
            var api = new GlassdoorApiConfiguration(GlassdoorApiParams.BaseUrl,
                GlassdoorApiParams.PartnerId,
                GlassdoorApiParams.ApiKey,
                GlassdoorApiParams.Vesrion,
                GlassdoorApiParams.Format,
                GlassdoorApiParams.UserIP,
                GlassdoorApiParams.UserAgent);
            #endregion

            //Temp testing
            var baseService = new BaseApiClient(api);
            var client = new CompanyRatingApiClient(baseService);

            //var testabc = client.GetCompanyRatingsAsync(161).Result;
            Console.WriteLine("done");
        }

    }
}
