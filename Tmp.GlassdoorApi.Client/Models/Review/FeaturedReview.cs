using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tmp.GlassdoorApi.Client.Models
{
    public class FeaturedReview
    {
        [JsonProperty("id")]
        public int Id { get; private set; }

        [JsonProperty("currentJob")]
        public string CurrentJob { get; private set; }

        [JsonProperty("reviewDateTime")]
        public DateTime ReviewDateTime { get; private set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; private set; }

        [JsonProperty("location")]
        public string Location { get; private set; }

        [JsonProperty("headline")]
        public string Headline { get; private set; }

        [JsonProperty("pros")]
        public string Pros { get; private set; }

        [JsonProperty("cons")]
        public string Cons { get; private set; }

        [JsonProperty("cultureAndValuesRating")]
        public int CultureAndValuesRating { get; private set; }

        [JsonProperty("seniorLeadershipRating")]
        public int SeniorLeadershipRating { get; private set; }

        [JsonProperty("CompensationAndBenefitsRating")]
        public int CompensationAndBenefitsRating { get; private set; }

        [JsonProperty("careerOpportunitiesRating")]
        public int CareerOpportunitiesRating { get; private set; }

        [JsonProperty("workLifeBalanceRating")]
        public int WorkLifeBalanceRating { get; private set; }

        [JsonProperty("recommendToFriendRating")]
        public double RecommendToFriendRating { get; private set; }

        [JsonProperty("recommendToFriendRatingCount")]
        public int RecommendToFriendRatingCount { get; private set; }

        [JsonProperty("attributionURL")]
        public string AttributionURL { get; private set; }

        [JsonProperty("jobTitleFromDb")]
        public string jobTitleFromDb { get; private set; }

        [JsonProperty("isFeaturedReview")]
        public bool IsFeaturedReview { get; private set; }

        [JsonProperty("lengthOfEmployment")]
        public string LengthOfEmployment { get; private set; }

        [JsonProperty("employmentStatus")]
        public string EmploymentStatus { get; private set; }

        [JsonProperty("jobInformation")]
        public string JobInformation { get; private set; }

        [JsonProperty("newReviewFlag")]
        public bool NewReviewFlag { get; private set; }

        [JsonProperty("advice")]
        public string Advice { get; private set; }

        [JsonProperty("businessOutlook")]
        public string BusinessOutlook { get; private set; }

        [JsonProperty("overallNumeric")]
        public int OverallNumeric { get; private set; }

        [JsonProperty("overall")]
        public string Overall { get; private set; }

        [JsonProperty("ceoRating")]
        public int CeoRating { get; private set; }

        [JsonProperty("ceoApproval")]
        public string CeoApproval { get; private set; }

        [JsonProperty("recommendToFriend")]
        public bool RecommendToFriend { get; private set; }

        [JsonProperty("helpfulCount")]
        public int HelpfulCount { get; private set; }

        [JsonProperty("notHelpfulCount")]
        public int NotHelpfulCount { get; private set; }

        [JsonProperty("totalHelpfulCount")]
        public int TotalHelpfulCount { get; private set; }
    }
}
