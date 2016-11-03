using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tmp.GlassdoorApi.Client.Models
{
    public class CompanyRatingDetail
    {
        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("shortName")]
        public string ShortName { get; private set; }

        [JsonProperty("size")]
        public string Size { get; private set; }

        [JsonProperty("headquarters")]
        public string Headquarters { get; private set; }

        [JsonProperty("industry")]
        public string Industry { get; private set; }

        [JsonProperty("type")]
        public string Type { get; private set; }

        [JsonProperty("symbol")]
        public string Symbol { get; private set; }

        [JsonProperty("ceoName")]
        public string CeoName { get; private set; }

        [JsonProperty("ceoSmallImageUrl")]
        public string CeoSmallImageUrl { get; private set; }

        [JsonProperty("ceoMediumImageUrl")]
        public string CeoMediumImageUrl { get; private set; }

        [JsonProperty("ceoLargeImageUrl")]
        public string CeoLargeImageUrl { get; private set; }

        [JsonProperty("ceoNormalImageUrl")]
        public string CeoNormalImageUrl { get; private set; }

        [JsonProperty("employerReviewCount")]
        public int EmployerReviewCount { get; private set; }
    }
}
