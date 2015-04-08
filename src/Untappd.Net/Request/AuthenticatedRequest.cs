using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Untappd.Net.Request
{
    public abstract class AuthenticatedRequest : BaseRequest
    {
        protected override abstract string _EndPoint { get; }
    }
}
