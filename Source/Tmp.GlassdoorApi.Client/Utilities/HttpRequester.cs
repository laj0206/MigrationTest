using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Tmp.GlassdoorApi.Client.Models;

namespace Tmp.GlassdoorApi.Client
{
    public static class HttpRequester
    {
        public static async Task<T> GetAsync<T>(string url) where T : class
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var request = new HttpRequestMessage(HttpMethod.Get, url);
                    request.Headers.Add("User-Agent", "Tmp.GlassdoorApi.Client");
                    request.Headers.Add("Accept", "application/json");

                    var httpResponse = await httpClient.SendAsync(request);

                    if (!httpResponse.IsSuccessStatusCode)
                    {
                        throw new GlassdoorException(string.Format("Bad request. Url: {0}", url));
                    }

                    var response = await httpResponse.Content.ReadAsStringAsync();

                    var result = JsonConvert.DeserializeObject<T>(response);

                    return result;
                }
            }
            catch (Exception exp)
            {
                throw new GlassdoorException("Fail to retrieve data from api.", exp);
            }

        }
    }
}
