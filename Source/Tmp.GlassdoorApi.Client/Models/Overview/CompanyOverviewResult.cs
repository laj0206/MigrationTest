using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tmp.GlassdoorApi.Client.Models
{
    public class CompanyOverviewResult: CompanyBase
    {
        [JsonProperty("isEEP")]
        public bool IsEEP { get; private set; }

        [JsonProperty("hq")]
        public string Headquarters { get; private set; }

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

        [JsonProperty("yearFound")]
        public int YearFound { get; private set; }

        [JsonProperty("type")]
        public string Type { get; private set; }

        [JsonProperty("size")]
        public string Size { get; private set; }

        [JsonProperty("revenue")]
        public string Revenue { get; private set; }

        [JsonProperty("competitors")]
        public string Competitors { get; private set; }

        [JsonProperty("description")]
        public string Description { get; private set; }

        [JsonProperty("missionStatement")]
        public string MissionStatement { get; private set; }

        [JsonProperty("overviewPhoto")]
        public string OverviewPhoto { get; private set; }

        [JsonProperty("employerReviewsURL")]
        public string EmployerReviewsURL { get; private set; }

        [JsonProperty("isOpenCompany")]
        public bool IsOpenCompany { get; private set; }

        [JsonProperty("employerStatusUpdates")]
        public string[] EmployerStatusUpdates { get; private set; }

        [JsonProperty("benefitsOverallRating")]
        public string BenefitsOverallRating { get; private set; }

        [JsonProperty("companyPhotos")]
        public CompanyPhoto[] CompanyPhotos { get; private set; }

        [JsonProperty("overviewReview")]
        public OverviewReview OverviewReview { get; private set; }

        [JsonProperty("overviewSalaries")]
        public OverReviewSalary OverReviewSalaries { get; private set; }

        [JsonProperty("overviewInterviews")]
        public OverviewInterview[] OverviewInterviews { get; private set; }

        [JsonProperty("awards")]
        public Awards Awards { get; private set; }
    }
}
