using Untappd.Net.Client;

namespace Untappd.Net.Request
{
    public partial class Repository
    {
        public dynamic Post(IAuthenticatedUntappdCredentials credentials, IAction action)
        {
            ConfigureRequest(action.EndPoint, action.BodyParameters);
            Request.AddParameter("access_token", credentials.AccessToken);
            return ExecuteRequest<dynamic>();
        }
    }
}
