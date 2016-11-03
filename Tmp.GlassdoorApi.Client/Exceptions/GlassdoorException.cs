using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tmp.GlassdoorApi.Client
{
    public class GlassdoorException: Exception
    {
        public GlassdoorException(string message) 
            : base(message)
        {

        }

        public GlassdoorException(string message, Exception exp) 
            : base(message, exp)
        {

        }
    }
}
