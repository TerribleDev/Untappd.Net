using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Untappd.Net.Client
{
    public abstract class UntappdCredentials : IUntappdCredentials
    {
        public IReadOnlyDictionary<string, string> AuthenticationData { get; protected set; }
    }
}
