using System.Collections;
using System.Collections.Generic;

namespace Untappd.Net.Client
{
    public interface IUntappdCredentials
    {
        IReadOnlyDictionary<string, string> AuthenticationData { get; } 
    }
}
