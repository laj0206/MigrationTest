using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tmp.GlassdoorApi.Client.Models
{
    public class CompanySearchResult
    {
        [JsonProperty("employers")]
        public IEnumerable<CompanyDetail> Companies { get; private set; }

        [JsonProperty("currentPageNumber")]
        public int CurrentPageNumber { get; private set; }

        [JsonProperty("totalNumberOfPages")]
        public int TotalPages { get; private set; }

        [JsonProperty("totalRecordCount")]
        public int TotalRecordCount { get; private set; }
    }
}
