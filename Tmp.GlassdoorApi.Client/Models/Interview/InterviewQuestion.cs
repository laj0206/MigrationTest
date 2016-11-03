using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tmp.GlassdoorApi.Client.Models
{
    public class InterviewQuestion
    {
        [JsonProperty("attributionURL")]
        public string AttributionURL { get; private set; }

        [JsonProperty("id")]
        public int Id { get; private set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; private set; }

        [JsonProperty("employer")]
        public string Employer { get; private set; }

        [JsonProperty("squareLogo")]
        public string SquareLogo { get; private set; }

        [JsonProperty("question")]
        public string Question { get; private set; }

        [JsonProperty("date")]
        public DateTime Date { get; private set; }

        [JsonProperty("helpfulCount")]
        public int HelpfulCount { get; private set; }

        [JsonProperty("totalHelpfulCount")]
        public int TotalHelpfulCount { get; private set; }

        [JsonProperty("locationCity")]
        public string LocationCity { get; private set; }

        [JsonProperty("locationState")]
        public string LocationState { get; private set; }

        [JsonProperty("locationCountry")]
        public string LocationCountry { get; private set; }

        [JsonProperty("responses")]
        public string[] Responses { get; private set; }
    }
}
