using System;

namespace Untappd.Net.Client
{
    public class UnAuthenticatedUntappdCredentials : UntappdCredentials, IUnAuthenticadedUntappdCredentials
    {
        /// <summary>
        /// UnAuthenticated request. Pass your API id and secret
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        public UnAuthenticatedUntappdCredentials(string clientId, string clientSecret)
            : base(clientId, clientSecret)
        {   
        }
    }
}
