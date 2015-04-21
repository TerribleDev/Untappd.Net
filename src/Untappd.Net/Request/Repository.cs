using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Untappd.Client.Net;
using Untappd.Net.Client;

namespace Untappd.Net.Request
{
    public class Repository
    {
        /// <summary>
        /// Get the things!
        /// </summary>
        /// <typeparam name="TResult">What you want to request</typeparam>
        /// <param name="credentials">Pass in a credentials object</param>
        /// <param name="urlParameter">this is the main parameter for a request. ie v4/user/checkins/urlParameter. Consult the untappd docs, this can be null for a few requests</param>
        /// <param name="bodyParameters">Any additional params you wish to add to the request</param>
        /// <returns></returns>
        public TResult Get<TResult> (IUnAuthenticadedUntappdCredentials credentials, string urlParameter, IDictionary<string, string> bodyParameters = null)
            where TResult : UnAuthenticatedRequest,new()
        {
           // throw new NotImplementedException();
            var result = new TResult();
            var client = new RestClient(Constants.BaseRequestString);
            var request = new RestRequest(result.EndPoint(urlParameter), Method.GET);
            request.AddParameter("client_id", credentials.ClientId);
            request.AddParameter("client_secret", credentials.ClientSecret);
            if (bodyParameters != null)
                foreach (var x in bodyParameters)
                {
                    request.AddParameter(x.Key, x.Value);
                }
            var resp = client.Execute(request);
            var jsonresult = JsonConvert.DeserializeObject<TResult>(resp.Content);
            return jsonresult;

        }

        public TResult Get<TResult>(IAuthenticatedUntappdCredentials credentials, string parameter = "", IDictionary<string, string> bodyParameters = null)
            where TResult : AuthenticatedRequest, new()
        {
            var result = new TResult();
            var client = new RestClient(Constants.BaseRequestString);
            var request = new RestRequest(result.EndPoint(parameter), Method.GET);
            request.AddParameter("access_token", credentials.AccessToken);
            if (bodyParameters != null)
                foreach (var param in bodyParameters)
                    request.AddParameter(param.Key, param.Value);

            var resp = client.Execute(request);
            var jsonresult = JsonConvert.DeserializeObject<TResult>(resp.Content);
            return jsonresult;
        }
    }
}
