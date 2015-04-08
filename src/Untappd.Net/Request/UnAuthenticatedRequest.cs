using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Untappd.Net.Request
{
    public abstract class UnAuthenticatedRequest : AuthenticatedRequest
    {
        protected override abstract string _EndPoint { get; }

    }
}
