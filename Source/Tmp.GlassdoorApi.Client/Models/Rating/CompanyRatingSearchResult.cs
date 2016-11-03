using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tmp.GlassdoorApi.Client.Models
{
    public class CompanyRatingSearchResult
    {
        [JsonProperty("attributionURL")]
        public string AttributionURL { get; private set; }

        [JsonProperty("employerInfo")]
        public CompanyRatingDetail CompanyInfo { get; private set; }

        [JsonProperty("reviewTrends")]
        public IEnumerable<ReviewTrend> ReviewTrends { get; private set; }

        [JsonProperty("weeklyHistogram")]
        public IEnumerable<WeeklyHistogram> WeeklyHistograms { get; private set; }
    }
}
