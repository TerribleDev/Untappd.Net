using System;
using Untappd.Net.Authentication;

namespace Untappd.Net.OAuth
{
    public static class AuthenticationHelper
    {
        /// <summary>
        /// Redirect the user to this string.
        /// </summary>
        /// <param name="credentials"></param>
        /// <param name="redirectUrl">The URL to redirect back to your application. Should listen on code as a string param</param>
        /// <returns></returns>
        public static string RedirectUserTo(IUnAuthenticatedUntappdCredentials credentials, string redirectUrl)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }

            if (string.IsNullOrWhiteSpace(redirectUrl))
            {
                throw new ArgumentNullException("redirectUrl");
            }
           
            return string.Format("{0}/?client_id={1}&response_type=code&redirect_url={2}", Constants.BaseRequestString,
                credentials.AuthenticationData["client_id"], redirectUrl);
        }

        /// <summary>
        /// Url to get the OAuth token.
        /// </summary>
        /// <param name="credentials"></param>
        /// <param name="redirectUrl"></param>
        /// <param name="code">Data returned by the initial request(see: RedirectUserTo)</param>
        /// <returns></returns>
        public static string TokenUrl(IUnAuthenticatedUntappdCredentials credentials, string redirectUrl, string code)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }

            if (string.IsNullOrWhiteSpace(redirectUrl))
            {
                throw new ArgumentNullException("redirectUrl");
            }
            if (string.IsNullOrWhiteSpace(code))
            {
                throw new ArgumentNullException("code");
            }
            return string.Format("{0}/?client_id={1}&client_secret={2}&response_type=code&redirect_url={3}&code={4}", 
                Constants.OAuthTokenEndPoint, 
                credentials.AuthenticationData["client_id"], 
                credentials.AuthenticationData["client_secret"],
                redirectUrl, 
                code);
        }
    }
}
