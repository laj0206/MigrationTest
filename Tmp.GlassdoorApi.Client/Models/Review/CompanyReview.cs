using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tmp.GlassdoorApi.Client.Models
{
    public class CompanyReview: Company
    {
        [JsonProperty("hq")]
        public string Headquarters { get; private set; }

        [JsonProperty("reviewsUrl")]
        public string ReviewsUrl { get; private set; }

        [JsonProperty("reviewsAnchorText")]
        public string ReviewsAnchorText { get; private set; }

        [JsonProperty("jobsUrl")]
        public string JobsUrl { get; private set; }

        [JsonProperty("jobsAnchorText")]
        public string JobsAnchorText { get; private set; }

        [JsonProperty("starImageSrc")]
        public string StarImageSrc { get; private set; }

        [JsonProperty("recommendToFriendRatingCount")]
        public string RecommendToFriendRatingCount { get; private set; }

        [JsonProperty("employmentStatusfilter")]
        public string[] EmploymentStatusfilter { get; private set; }

        [JsonProperty("reviewCount")]
        public int ReviewCount { get; private set; }

        [JsonProperty("salaryCount")]
        public int SalaryCount { get; private set; }

        [JsonProperty("interviewCount")]
        public int InterviewCount { get; private set; }

        [JsonProperty("photoCount")]
        public int PhotoCount { get; private set; }

        [JsonProperty("jobCount")]
        public int JobCount { get; private set; }

        [JsonProperty("companyPhotos")]
        public string[] CompanyPhotos { get; private set; }

        [JsonProperty("isOpenCompany")]
        public bool IsOpenCompany { get; private set; }

        [JsonProperty("isEmployerRep")]
        public bool IsEmployerRep { get; private set; }

        [JsonProperty("overviewPhoto")]
        public string OverviewPhoto { get; private set; }

        [JsonProperty("reviewHighlights")]
        public ReviewHighlights ReviewHighlights { get; private set; }
    }
}
