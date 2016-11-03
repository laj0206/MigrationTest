using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tmp.GlassdoorApi.Client.Models
{
    public class Company: CompanyBase
    {
        [JsonProperty("isEEP")]
        public bool IsEEP { get; private set; }

        [JsonProperty("id")]
        public string ID { get; private set; }

        [JsonProperty("ratingDescription")]
        public string RatingDescription { get; private set; }

        [JsonProperty("cultureAndValuesRating")]
        public decimal CultureAndValuesRating { get; private set; }

        [JsonProperty("seniorLeadershipRating")]
        public decimal SeniorLeadershipRating { get; private set; }

        [JsonProperty("compensationAndBenefitsRating")]
        public decimal CompensationAndBenefitsRating { get; private set; }

        [JsonProperty("careerOpportunitiesRating")]
        public decimal CareerOpportunitiesRating { get; private set; }

        [JsonProperty("workLifeBalanceRating")]
        public decimal WorkLifeBalanceRating { get; private set; }

        [JsonProperty("recommendToFriendRating")]
        public decimal RecommendToFriendRating { get; private set; }

        [JsonProperty("sectorId")]
        public int SectorId { get; private set; }

        [JsonProperty("sectorName")]
        public string SectorName { get; private set; }

        [JsonProperty("industryId")]
        public int IndustryId { get; private set; }

        [JsonProperty("industryName")]
        public string IndustryName { get; private set; }

        [JsonProperty("ceo")]
        public Ceo Ceo { get; private set; }
    }
}
