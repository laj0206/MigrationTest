using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tmp.GlassdoorApi.Client.Models
{
    public class SalaryGroup
    {
        [JsonProperty("attributionURL")]
        public string AttributionURL { get; private set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; private set; }

        [JsonProperty("jobTitleId")]
        public int JobTitleId { get; private set; }

        [JsonProperty("count")]
        public int Count { get; private set; }

        [JsonProperty("min")]
        public decimal Min { get; private set; }

        [JsonProperty("max")]
        public decimal Max { get; private set; }

        [JsonProperty("mean")]
        public decimal Mean { get; private set; }

        [JsonProperty("payPeriod")]
        public string PayPeriod { get; private set; }

        [JsonProperty("obscureType")]
        public string ObscureType { get; private set; }

        [JsonProperty("employmentStatus")]
        public string EmploymentStatus { get; private set; }

        [JsonProperty("perOccEmployerDefaultCountryBasePayCount")]
        public int PerOccEmployerDefaultCountryBasePayCount { get; private set; }

        [JsonProperty("perOccUnfilteredThisCountryBasePayCount")]
        public int PerOccUnfilteredThisCountryBasePayCount { get; private set; }
    }
}
