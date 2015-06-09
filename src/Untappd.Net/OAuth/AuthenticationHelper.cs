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
                throw new ArgumentNullException(nameof(credentials));
            }

            if (string.IsNullOrWhiteSpace(redirectUrl))
            {
                throw new ArgumentNullException(nameof(redirectUrl));
            }

            return $"{Constants.BaseRequestString}/?client_id={                credentials.AuthenticationData["client_id"]}&response_type=code&redirect_url={redirectUrl}";
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
                throw new ArgumentNullException(nameof(credentials));
            }

            if (string.IsNullOrWhiteSpace(redirectUrl))
            {
                throw new ArgumentNullException(nameof(redirectUrl));
            }
            if (string.IsNullOrWhiteSpace(code))
            {
                throw new ArgumentNullException(nameof(code));
            }
            return $"{Constants.OAuthTokenEndPoint}/?client_id={credentials.AuthenticationData["client_id"]}&client_secret={credentials.AuthenticationData["client_secret"]}&response_type=code&redirect_url={redirectUrl}&code={code}";
        }
    }
}
