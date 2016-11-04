using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tmp.GlassdoorApi.Client.Models;

namespace Tmp.GlassdoorApi.Client
{
    public class BaseApiClient: IBaseApiClient
    {
        private GlassdoorApiConfiguration Api { get; set; }

        public BaseApiClient(GlassdoorApiConfiguration api)
        {
            this.Api = api;
        }

        public GlassdoorApiConfiguration GetClient()
        {
            return this.Api;
        }
    }
}
