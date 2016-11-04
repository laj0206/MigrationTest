using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tmp.GlassdoorApi.Client.Models
{
    public class CompanySearchResponse: Response
    {
        [JsonProperty("response")]
        public CompanySearchResult Result { get; private set; }
    }
}
