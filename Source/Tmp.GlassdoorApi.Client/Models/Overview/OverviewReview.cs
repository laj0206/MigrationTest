using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tmp.GlassdoorApi.Client.Models
{
    public class OverviewReview
    {
        [JsonProperty("ceo")]
        public Ceo Ceo { get; private set; }

        [JsonProperty("featuredReview")]
        public FeaturedReview FeaturedReview { get; private set; }
    }
}
