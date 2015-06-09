using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Untappd.Net.Authentication
{
    public sealed class UnAuthenticatedUntappdCredentials : BaseUntappdCredentials, IUnAuthenticatedUntappdCredentials
    {
        /// <summary>
        /// UnAuthenticated request. Pass your API id and secret
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        public UnAuthenticatedUntappdCredentials(string clientId, string clientSecret)
        {
            if (string.IsNullOrWhiteSpace(clientId))
            {
                throw new ArgumentNullException(nameof(clientId));
            }
            if (string.IsNullOrWhiteSpace(clientSecret))
            {
                throw new ArgumentNullException(nameof(clientSecret));
            }
            AuthenticationData = new ReadOnlyDictionary<string, string>(new Dictionary<string, string>
            {
                {"client_id", clientId}, {"client_secret", clientSecret}
            });
        }
    }
}
