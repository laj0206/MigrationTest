using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tmp.GlassdoorApi.Client.Models
{
    public class OverReviewSalary
    {
        [JsonProperty("job")]
        public SalaryGroup[] Jobs { get; private set; }
    }
}
