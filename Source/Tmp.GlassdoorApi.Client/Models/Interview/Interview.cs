using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tmp.GlassdoorApi.Client.Models
{
    public class Interview: CompanyBase
    {
        [JsonProperty("hq")]
        public string Headquarters { get; private set; }

        [JsonProperty("reviewsUrl")]
        public string ReviewsUrl { get; private set; }

        [JsonProperty("reviewsAnchorText")]
        public string ReviewsAnchorText { get; private set; }

        [JsonProperty("jobsUrl")]
        public string JobsUrl { get; private set; }

        [JsonProperty("starImageSrc")]
        public string StarImageSrc { get; private set; }

        [JsonProperty("interviewCount")]
        public int InterviewCount { get; private set; }

        [JsonProperty("overallDifficultyCount")]
        public int OverallDifficultyCount { get; private set; }

        [JsonProperty("overallDifficultySum")]
        public int OverallDifficultySum { get; private set; }

        [JsonProperty("averageOverallDifficulty")]
        public decimal AverageOverallDifficulty { get; private set; }

        [JsonProperty("overallExperienceCount")]
        public int OverallExperienceCount { get; private set; }

        [JsonProperty("overallPosExperienceCount")]
        public int OverallPosExperienceCount { get; private set; }

        [JsonProperty("overallPosExperiencePercent")]
        public decimal OverallPosExperiencePercent { get; private set; }

        [JsonProperty("overallNeutExperienceCount")]
        public int OverallNeutExperienceCount { get; private set; }

        [JsonProperty("overallNeutExperiencePercent")]
        public decimal OverallNeutExperiencePercent { get; private set; }

        [JsonProperty("overallNegexperienceCount")]
        public int OverallNegexperienceCount { get; private set; }

        [JsonProperty("overallNegExperiencePercent")]
        public decimal OverallNegExperiencePercent { get; private set; }

        [JsonProperty("isOpenCompany")]
        public bool IsOpenCompany { get; private set; }

        [JsonProperty("reviewCount")]
        public int ReviewCount { get; private set; }

        [JsonProperty("salaryCount")]
        public int SalaryCount { get; private set; }

        [JsonProperty("photoCount")]
        public int PhotoCount { get; private set; }

        [JsonProperty("jobCount")]
        public int JobCount { get; private set; }
    }
}
