using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Untappd.Net.Authentication
{
    public sealed class AuthenticatedUntappdCredentials : BaseUntappdCredentials, IAuthenticatedUntappdCredentials
    {
        /// <summary>
        /// Pass your authenticated access token
        /// </summary>
        /// <param name="accessToken"></param>
        public AuthenticatedUntappdCredentials(string accessToken)
        {
            if (string.IsNullOrWhiteSpace(accessToken))
            {
                throw new ArgumentNullException(nameof(accessToken));
            }
            AuthenticationData = new ReadOnlyDictionary<string, string>(new Dictionary<string, string>
            {
                {"access_token", accessToken}
            });
        }
    }
}
