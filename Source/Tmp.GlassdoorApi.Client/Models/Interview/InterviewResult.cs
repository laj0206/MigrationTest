using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tmp.GlassdoorApi.Client.Models
{
    public class InterviewResult
    {
        [JsonProperty("employer")]
        public Interview Interview { get; private set; }

        [JsonProperty("isEmployerRep")]
        public bool IsEmployerRep { get; private set; }

        [JsonProperty("ceo")]
        public Ceo Ceo { get; private set; }
    }
}
