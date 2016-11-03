using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tmp.GlassdoorApi.Client.Models
{
    public class Ceo
    {
        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("title")]
        public string Title { get; private set; }

        [JsonProperty("numberOfRatings")]
        public int NumberOfRatings { get; private set; }

        [JsonProperty("pctApprove")]
        public decimal ApprovalPercentage { get; private set; }

        [JsonProperty("pctDisapprove")]
        public decimal DisapprovalPercentage { get; private set; }

        [JsonProperty("image")]
        public Image Image { get; private set; }
    }
}
