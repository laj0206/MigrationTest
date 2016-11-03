using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tmp.GlassdoorApi.Client.Models
{
    public class WeeklyHistogram
    {
        [JsonProperty("year")]
        public int Year { get; private set; }

        [JsonProperty("interval")]
        public int Interval { get; private set; }

        [JsonProperty("individualRatings")]
        public IEnumerable<IndividualRating> IndividualRatings { get; private set; }
    }
}
