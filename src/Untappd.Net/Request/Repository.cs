using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using Untappd.Net.Authentication;
using Untappd.Net.Exception;

namespace Untappd.Net.Request
{
    public sealed partial class Repository
    {
        internal IRestClient Client;
        internal IRestRequest Request;
        public bool FailFast { get; set; }
        /// <summary>
        /// Event to listen to when failFast is set to false
        /// This allows you to capture the excpetion, before its swallowed
        /// </summary>
        public event UnhandledExceptionEventHandler OnExceptionThrown;

        /// <summary>
        /// Make a repository
        /// </summary>
        /// <param name="failFast">Should we throw exceptions? or just return null</param>
        public Repository(bool failFast = true)
        {
            Client = new RestClient(Constants.BaseRequestString);
            Request = new RestRequest();
            FailFast = failFast;
        }

        [Obsolete("This constructor is used for mocking purposes only", false)]
        internal Repository(IRestClient client, IRestRequest request)
        {
            Client = client;
            Request = request;
        }

        internal Repository ConfigureRequest(string endPoint, IDictionary<string, object> bodyParameters = null, Method webMethod = Method.GET)
        {
            Request.Resource = endPoint;
            Request.Method = webMethod;
            if (Request.Parameters != null && Request.Parameters.Count > 0)
            {
                Request.Parameters.Clear();
            }

            if (bodyParameters == null) return this;
            foreach (var param in bodyParameters)
            {
                Request.AddParameter(param.Key, param.Value);
            }
            return this;
        }

        internal Repository ConfigureRequest(IUntappdCredentials credentials, string endPoint, IDictionary<string, object> bodyParameters = null, Method webMethod = Method.GET)
        {
            ConfigureRequest(endPoint, bodyParameters, webMethod);
            foreach (var untappdCredential in credentials.AuthenticationData)
            {
                Request.AddParameter(untappdCredential.Key, untappdCredential.Value);
            }
            return this;
        } 

        TResult ExecuteRequest<TResult>()
            where TResult : class 
        {
            return ProcessExecution<TResult>(Client.Execute(Request));
        }

        async Task<TResult> ExecuteRequestAsync<TResult>()
            where TResult : class 
        {
            return ProcessExecution<TResult>(await Client.ExecuteTaskAsync(Request));
        }

        TResult ProcessExecution<TResult>(IRestResponse response)
            where TResult : class 
        {
            //if the return type is not 200 throw errors
            if (response.StatusCode != HttpStatusCode.OK)
            {
                var excpetion = new HttpErrorException(Request, response);
                var eventThrow = OnExceptionThrown;

                if (eventThrow != null)
                {
                    eventThrow(this, new UnhandledExceptionEventArgs(excpetion, FailFast));
                }
                if (FailFast)
                {
                    throw excpetion;
                }
                return null;
            }
            //try to deserialize
            try
            {
                return JsonConvert.DeserializeObject<TResult>(response.Content);
            }
            catch(System.Exception e)
            {
                var eventThrow = OnExceptionThrown;

                if (eventThrow != null)
                {
                        eventThrow(this, new UnhandledExceptionEventArgs(e, FailFast));
                }
                if (FailFast)
                {
                    throw;
                }
               
                return null;
            }
        }
    }
}
