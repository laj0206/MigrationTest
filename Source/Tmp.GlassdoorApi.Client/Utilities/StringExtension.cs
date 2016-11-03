using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading.Tasks;

namespace Tmp.GlassdoorApi.Client
{
    public static class StringExtension
    {
        public static string Parameters(this string str,
            NameValueCollection collection)
        {
            if (collection != null)
            {
                var array = (from key in collection.AllKeys
                             from value in collection.GetValues(key)
                             select string.Format("{0}={1}",
                                                    HttpUtility.UrlPathEncode(key),
                                                    string.IsNullOrEmpty(value) ? string.Empty : HttpUtility.UrlPathEncode(value)))
                            .ToArray();
                var sb = new StringBuilder().Append(str).Append("?").Append(string.Join("&", array));
                return sb.ToString();
            }
            return str;
        }
    }
}
