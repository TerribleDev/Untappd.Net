using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Untappd.Net.Client
{
    public interface IUntappdCredentials
    {
        string ClientId { get; }
        string ClientSecret { get; }
    }
}
