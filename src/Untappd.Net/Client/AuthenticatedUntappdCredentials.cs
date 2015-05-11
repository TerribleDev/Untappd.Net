using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Untappd.Net.Client
{
    public class AuthenticatedUntappdCredentials : UntappdCredentials, IAuthenticatedUntappdCredentials
    {
        /// <summary>
        /// Pass your authenticated access token
        /// </summary>
        /// <param name="accessToken"></param>
        public AuthenticatedUntappdCredentials(string accessToken)
        {
            if (string.IsNullOrWhiteSpace(accessToken))
            {
                throw new ArgumentNullException("accessToken");
            }
            AuthenticationData = new ReadOnlyDictionary<string, string>(new Dictionary<string, string>()
            {
                {"access_token", accessToken}
            });
        }
    }
}
