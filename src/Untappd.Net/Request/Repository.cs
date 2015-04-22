using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using Untappd.Net.Client;
using System.Threading;

namespace Untappd.Net.Request
{
    public class Repository
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

        private void ConfigureGetRequest(IRestRequest request, string endPoint, IDictionary<string, string> bodyParameters = null)
        {
            request.Resource = endPoint;
            request.Method = Method.GET;
            if (request.Parameters != null) this.Request.Parameters.Clear();

            if (bodyParameters != null)
                foreach (var param in bodyParameters)
                    request.AddParameter(param.Key, param.Value);
        }

        /// <summary>
        /// Get the things!
        /// </summary>
        /// <typeparam name="TResult">What you want to request</typeparam>
        /// <param name="credentials">Pass in a credentials object</param>
        /// <param name="urlParameter">this is the main parameter for a request. ie v4/user/checkins/urlParameter. Consult the untappd docs, this can be null for a few requests</param>
        /// <param name="bodyParameters">Any additional params you wish to add to the request</param>
        /// <returns></returns>
        public TResult Get<TResult> (IUnAuthenticatedUntappdCredentials credentials, string urlParameter, IDictionary<string, string> bodyParameters = null)
            where TResult : IUnAuthenticatedRequest,new()
        {
            var result = new TResult();
            this.ConfigureGetRequest(this.Request, result.EndPoint(urlParameter), bodyParameters);
            
            this.Request.AddParameter("client_id", credentials.ClientId);
            this.Request.AddParameter("client_secret", credentials.ClientSecret);

            return this.DoRestRequest<TResult>(this.Request);
        }

        /// <summary>
        /// Get the things! authenticated!
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="credentials">Pass in a credentials object</param>
        /// <param name="urlParameter">this is the main parameter for a request. ie v4/user/checkins/urlParameter. Consult the untappd docs, this can be null for a few requests</param>
        /// <param name="bodyParameters">Any additional params you wish to add to the request</param>
        /// <returns></returns>
        public TResult Get<TResult>(IAuthenticatedUntappdCredentials credentials, string urlParameter = "", IDictionary<string, string> bodyParameters = null)
            where TResult : IAuthenticatedRequest, new()
        {
            var result = new TResult();
            this.ConfigureGetRequest(this.Request, result.EndPoint(urlParameter), bodyParameters);

            this.Request.AddParameter("access_token", credentials.AccessToken);

            return this.DoRestRequest<TResult>(this.Request);
        }

        private TResult DoRestRequest<TResult>(IRestRequest request)
        {
            var client = new RestClient(Constants.BaseRequestString);
            var resp = client.Execute(request);
            return JsonConvert.DeserializeObject<TResult>(resp.Content);
        }

        //private async Task<TResult> DoRestRequestAsync<TResult>(IRestRequest request)
        //{
        //    var client = new RestClient(Constants.BaseRequestString);
        //    var cancellationTokenSource = new CancellationTokenSource();
        //    var resp = await client.ExecuteTaskAsync(request, cancellationTokenSource.Token);
        //    return JsonConvert.DeserializeObject<TResult>(resp.Content);
        //}
    }
}
