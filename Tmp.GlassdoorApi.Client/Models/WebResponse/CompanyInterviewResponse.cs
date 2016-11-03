using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tmp.GlassdoorApi.Client.Models
{
    public class CompanyInterviewResponse: Response
    {
        [JsonProperty("response")]
        public InterviewResult Result { get; private set; }
    }
}
