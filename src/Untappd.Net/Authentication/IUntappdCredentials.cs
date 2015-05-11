using System.Collections.Generic;

namespace Untappd.Net.Authentication
{
    public interface IUntappdCredentials
    {
        IReadOnlyDictionary<string, string> AuthenticationData { get; } 
    }
}
