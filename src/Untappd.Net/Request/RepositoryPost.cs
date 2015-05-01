using System.Threading.Tasks;
using Untappd.Net.Client;

namespace Untappd.Net.Request
{
    public partial class Repository
    {
        /// <summary>
        /// do a post with actions
        /// </summary>
        /// <param name="credentials"></param>
        /// <param name="action"></param>
        /// <returns>returns dynamic since often the return doesn't matter</returns>
        public dynamic Post(IAuthenticatedUntappdCredentials credentials, IAction action)
        {
            ConfigureRequest(action.EndPoint, action.BodyParameters);
            Request.AddParameter("access_token", credentials.AccessToken);
            return ExecuteRequest<dynamic>();
        }

        /// <summary>
        /// do a post with actions, Async!
        /// </summary>
        /// <param name="credentials"></param>
        /// <param name="action"></param>
        /// <returns>returns dynamic since often the return doesn't matter</returns>
        public Task<dynamic> PostAsync(IAuthenticatedUntappdCredentials credentials, IAction action)
        {
            ConfigureRequest(action.EndPoint, action.BodyParameters);
            Request.AddParameter("access_token", credentials.AccessToken);
            return ExecuteRequestAsync<dynamic>();
        }
    }
}
