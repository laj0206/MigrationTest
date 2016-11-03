using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tmp.GlassdoorApi.Client
{
    public class BaseApiClient: IBaseApiClient
    {
        private int partnerId = 87106;
        private string apiKey = "en67yaE36Vw";
        private string baseUrl = "http://api.glassdoor.com/api/api.htm";

        public BaseApiClient() { }

        public GlassdoorApiConfiguration GetClient()
        {
            return new GlassdoorApiConfiguration(baseUrl,
                partnerId,
                apiKey);
        }
    }
}
