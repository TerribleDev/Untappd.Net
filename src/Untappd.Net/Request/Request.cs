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
    public class Request
    {
        public TResult Get<T, TResult> (T credentials, string parameter)
            where T : IUntappdCredentials
            where TResult : BaseRequest,new()
        {
           // throw new NotImplementedException();
            var result = new TResult();
            var client = new RestClient(result.baseRequestString);
            var request = new RestRequest(result.EndPoint(parameter), Method.GET);
            request.AddParameter("client_id", credentials.ClientId);
            request.AddParameter("client_secret", credentials.ClientSecret);
            var resp = client.Execute(request);
            var jsonresult = JsonConvert.DeserializeObject<TResult>(resp.Content);
            return jsonresult;

        }

        public TResult GetAuth<T, TResult>()
            where T : AuthenticatedUntappdCredentials
            where TResult : BaseRequest, new()
        {
            throw new NotImplementedException();
        }
    }
}
