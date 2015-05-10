using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using Untappd.Net.Client;

namespace Untappd.Net.Request
{
    public partial class Repository
    {
        internal IRestClient Client;
        internal IRestRequest Request;

        public Repository()
        {
            Client = new RestClient(Constants.BaseRequestString);
            Request = new RestRequest();
        }

        internal Repository(IRestClient client, IRestRequest request)
        {
            Client = client;
            Request = request;
        }

        internal void ConfigureRequest(string endPoint, IDictionary<string, object> bodyParameters = null , Method webMethod = Method.GET)
        {
            Request.Resource = endPoint;
            Request.Method = webMethod;
            if (Request.Parameters != null) Request.Parameters.Clear();

            if (bodyParameters == null) return;
            foreach (var param in bodyParameters)
            {
                Request.AddParameter(param.Key, param.Value);
            }
               
        }

        internal void ConfigureRequest(IUnAuthenticatedUntappdCredentials credentials, string endPoint, IDictionary<string, object> bodyParameters = null, Method webMethod = Method.GET)
        {
            ConfigureRequest(endPoint, bodyParameters, webMethod);
            Request.AddParameter("client_id", credentials.ClientId);
            Request.AddParameter("client_secret", credentials.ClientSecret);

        }

        internal void ConfigureRequest(IAuthenticatedUntappdCredentials credentials, string endPoint, IDictionary<string, object> bodyParameters = null, Method webMethod = Method.GET)
        {
            ConfigureRequest(endPoint, bodyParameters, webMethod);
            Request.AddParameter("access_token", credentials.AccessToken);
        } 

        private TResult ExecuteRequest<TResult>()
        {
            var response = Client.Execute(Request);
            return JsonConvert.DeserializeObject<TResult>(response.Content);
        }

        private async Task<TResult> ExecuteRequestAsync<TResult>()
        {
            var response = await Client.ExecuteTaskAsync(Request);
            return JsonConvert.DeserializeObject<TResult>(response.Content);
        }
    }
}
