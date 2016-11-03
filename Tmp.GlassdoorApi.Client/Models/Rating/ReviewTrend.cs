using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tmp.GlassdoorApi.Client.Models
{
    public class ReviewTrend
    {
        [JsonProperty("category")]
        public string Category { get; private set; }

        [JsonProperty("ratingCounts")]
        public string[] RatingCounts { get; private set; }
    }
}
