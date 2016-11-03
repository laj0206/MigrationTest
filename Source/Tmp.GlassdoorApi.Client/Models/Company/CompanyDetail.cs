using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tmp.GlassdoorApi.Client.Models
{
    public class CompanyDetail: Company
    {
        [JsonProperty("exactMatch")]
        public bool ExactMatch { get; private set; }

        [JsonProperty("featuredReview")]
        public FeaturedReview FeaturedReview { get; private set; }
    }
}
