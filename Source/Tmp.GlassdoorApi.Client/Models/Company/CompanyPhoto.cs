using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tmp.GlassdoorApi.Client.Models
{
    public class CompanyPhoto
    {
        [JsonProperty("location")]
        public string Location { get; private set; }

        [JsonProperty("caption")]
        public string Caption { get; private set; }

        [JsonProperty("thumb")]
        public Image Thumb { get; private set; }
    }
}
