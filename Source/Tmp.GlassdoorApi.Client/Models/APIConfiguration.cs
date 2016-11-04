using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tmp.GlassdoorApi.Client.Models
{
    public class ApiConfiguration
    {
        public string BasicUrl { get; set; }
        public int PartnerID { get; set; }
        public string APIKey { get; set; }
        public string UserIP { get; set; }
        public int Version { get; set; }
        public string Format { get; set; }
        public string UserAgent { get; set; }

        public ApiConfiguration(string baseUrl,
            int partnerId,
            string apiKey,
            int version,
            string format,
            string userIp,
            string userAgent)
        {
            this.BasicUrl = baseUrl;
            this.PartnerID = partnerId;
            this.APIKey = apiKey;
            this.UserIP = userIp;
            this.Version = version;
            this.Format = format;
            this.UserAgent = userAgent;
        }
    }
}
