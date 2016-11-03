using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tmp.GlassdoorApi.Client.Models
{
    public class Award
    {
        [JsonProperty("year")]
        public int Year { get; private set; }

        [JsonProperty("source")]
        public string Source { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }
    }

    public class Awards
    {
        [JsonProperty("awards")]
        public IEnumerable<Award> AwardList { get; private set; }
    }
}
