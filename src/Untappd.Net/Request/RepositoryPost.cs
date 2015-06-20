using System.Threading.Tasks;
using Untappd.Net.Authentication;
using System;

namespace Untappd.Net.Request
{
    public sealed partial class Repository
    {
        /// <summary>
        /// do a post with actions
        /// </summary>
        /// <param name="credentials"></param>
        /// <param name="action"></param>
        /// <returns>returns dynamic since often the return doesn't matter</returns>
        public dynamic Post(IAuthenticatedUntappdCredentials credentials, IAction action)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (action == null)
            {
                throw new ArgumentNullException("action");
            }

            return ConfigureRequest(credentials, action.EndPoint, action.BodyParameters, action.RequestMethod) 
                .ExecuteRequest<dynamic>();
        }

        /// <summary>
        /// do a post with actions, Async!
        /// </summary>
        /// <param name="credentials"></param>
        /// <param name="action"></param>
        /// <returns>returns dynamic since often the return doesn't matter</returns>
        public Task<dynamic> PostAsync(IAuthenticatedUntappdCredentials credentials, IAction action)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (action == null)
            {
                throw new ArgumentNullException("action");
            }

            return ConfigureRequest(credentials, action.EndPoint, action.BodyParameters, action.RequestMethod)
            .ExecuteRequestAsync<dynamic>();
        }
    }
}
