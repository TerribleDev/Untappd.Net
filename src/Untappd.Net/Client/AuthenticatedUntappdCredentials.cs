using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Untappd.Client.Net;

namespace Untappd.Net.Client
{
    public class AuthenticatedUntappdCredentials : UntappdCredentials, IAuthenticatedUntappdCredentials
    {
        public string AccessToken { get; private set; }
        /// <summary>
        /// Pass your authenticated access token
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        public AuthenticatedUntappdCredentials(string accessToken, string clientId, string clientSecret)
            :base(clientId, clientSecret)
        {
            if (string.IsNullOrWhiteSpace(accessToken)) throw new ArgumentNullException("accessToken");
            AccessToken = string.Copy(accessToken);
        }
    }
}
