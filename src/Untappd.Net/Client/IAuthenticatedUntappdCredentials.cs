using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Untappd.Net.Client
{
    public interface IAuthenticatedUntappdCredentials : IUntappdCredentials
    {
        string AccessToken { get; }
    }
}
