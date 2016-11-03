using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tmp.GlassdoorApi.Client
{
    public interface IBaseApiClient
    {
        GlassdoorApiConfiguration GetClient();
    }
}
