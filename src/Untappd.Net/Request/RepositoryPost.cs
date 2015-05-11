using System.Threading.Tasks;
using Untappd.Net.Authentication;

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
            return ConfigureRequest(credentials, action.EndPoint, action.BodyParameters, action.RequestMethod)
            .ExecuteRequestAsync<dynamic>();
        }
    }
}
