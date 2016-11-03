using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tmp.GlassdoorApi.Client.Models
{
    public class ReviewHighlight
    {
        [JsonProperty("topPhrase")]
        public string TopPhrase { get; private set; }

        [JsonProperty("term")]
        public string Term { get; private set; }

        [JsonProperty("reviewCount")]
        public int ReviewCount { get; private set; }

        [JsonProperty("weight")]
        public string Weight { get; private set; }
    }
}
