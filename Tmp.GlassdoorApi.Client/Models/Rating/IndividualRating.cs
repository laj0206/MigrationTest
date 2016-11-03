using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tmp.GlassdoorApi.Client.Models
{
    public class IndividualRating
    { 
        [JsonProperty("category")]
        public string Category { get; private set; }

        [JsonProperty("rating")]
        public double Rating { get; private set; }
    }
}
