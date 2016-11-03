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
            //just for testing
            var baseService = new BaseApiClient();
            var client = new CompanyRatingApiClient(baseService);
            //end of testing

            var testabc = client.GetCompanyRatingsAsync(161).Result;
            Console.WriteLine("done");
        }

    }
}
