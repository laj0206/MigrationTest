using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tmp.GlassdoorApi.Client.Models
{
    public class Image
    {
        [JsonProperty("src")]
        public string Source { get; private set; }

        [JsonProperty("height")]
        public string Height { get; private set; }

        [JsonProperty("width")]
        public string Width { get; private set; }
    }
}
