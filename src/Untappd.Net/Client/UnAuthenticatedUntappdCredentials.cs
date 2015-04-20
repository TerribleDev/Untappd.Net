using System;

namespace Untappd.Net.Client
{
    public class UnAuthenticatedUntappdCredentials : IUntappdCredentials
    {
        public string ClientId { get; private set; }
        public string ClientSecret { get; private set; }

        /// <summary>
        /// UnAuthenticated request. Pass your API id and secret
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        public UnAuthenticatedUntappdCredentials(string clientId, string clientSecret)
        {
            if (string.IsNullOrWhiteSpace(clientId))
            {
                throw new ArgumentNullException("clientId");
            }
            if (string.IsNullOrWhiteSpace(clientSecret))
            {
                throw new ArgumentNullException("clientSecret");
            }
            ClientId = string.Copy(clientId);
            ClientSecret = string.Copy(clientSecret);
        }
    }
}
