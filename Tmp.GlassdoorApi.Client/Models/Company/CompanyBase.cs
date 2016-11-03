using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tmp.GlassdoorApi.Client.Models
{
    public class CompanyBase
    {
        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("website")]
        public string Website { get; private set; }

        [JsonProperty("industry")]
        public string Industry { get; private set; }

        [JsonProperty("numberOfRatings")]
        public int NumberOfRatings { get; private set; }

        [JsonProperty("overallRating")]
        public decimal OverallRating { get; private set; }

        [JsonProperty("squareLogo")]
        public string SquareLogo { get; private set; }
    }
}
