using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tmp.GlassdoorApi.Client.Models
{
    public class CompanyReviewResponse: Response
    {
        [JsonProperty("response")]
        public CompanyReviewResult Result { get; set; }
    }
}
