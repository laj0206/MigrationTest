using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tmp.GlassdoorApi.Client.Models
{
    public class ReviewHighlights
    {
        [JsonProperty("pros")]
        public IEnumerable<ReviewHighlight> Pros { get; private set; }

        [JsonProperty("cons")]
        public IEnumerable<ReviewHighlight> Cons { get; private set; }
    }
}
