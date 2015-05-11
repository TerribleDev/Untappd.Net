using System.Collections.Generic;
using System.Threading.Tasks;
using Untappd.Net.Client;
using Untappd.Net.Exception;

namespace Untappd.Net.Request
{
    public partial class Repository
    {
        /// <summary>
        /// Get the things!
        /// </summary>
        /// <typeparam name="TResult">What you want to request</typeparam>
        /// <param name="credentials">Pass in a credentials object</param>
        /// <param name="urlParameter">this is the main parameter for a request. ie v4/user/checkins/urlParameter. Consult the untappd docs, this can be null for a few requests</param>
        /// <param name="bodyParameters">Any additional params you wish to add to the request</param>
        /// <exception cref="HttpErrorException"></exception>
        /// <returns></returns>
        public TResult Get<TResult>(IUnAuthenticatedUntappdCredentials credentials, string urlParameter, IDictionary<string, object> bodyParameters = null)
            where TResult : class, IUnAuthenticatedRequest, new()
        {
            var result = new TResult();
            return ConfigureRequest(credentials, result.EndPoint(urlParameter), bodyParameters)
            .ExecuteRequest<TResult>();
        }

        /// <summary>
        /// Get the things! Async!
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="credentials"></param>
        /// <param name="urlParameter"></param>
        /// <param name="bodyParameters"></param>
        /// <exception cref="HttpErrorException"></exception>
        /// <returns></returns>
        public Task<TResult> GetAsync<TResult>(IUnAuthenticatedUntappdCredentials credentials, string urlParameter, IDictionary<string, object> bodyParameters = null)
           where TResult : class, IUnAuthenticatedRequest, new()
        {
            var result = new TResult();
            return ConfigureRequest(credentials, result.EndPoint(urlParameter), bodyParameters)
            .ExecuteRequestAsync<TResult>();
        }

        /// <summary>
        /// Get the things! authenticated!
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="credentials">Pass in a credentials object</param>
        /// <param name="urlParameter">this is the main parameter for a request. ie v4/user/checkins/urlParameter. Consult the untappd docs, this can be null for a few requests</param>
        /// <param name="bodyParameters">Any additional params you wish to add to the request</param>
        /// <exception cref="HttpErrorException"></exception>
        /// <returns></returns>
        public TResult Get<TResult>(IAuthenticatedUntappdCredentials credentials, string urlParameter = "", IDictionary<string, object> bodyParameters = null)
            where TResult : class,IAuthenticatedRequest, new()
        {
            var result = new TResult();
            return ConfigureRequest(credentials, result.EndPoint(urlParameter), bodyParameters) 
            .ExecuteRequest<TResult>();
        }

        /// <summary>
        /// Get the things Authenticated! Async!!
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="credentials"></param>
        /// <param name="urlParameter"></param>
        /// <param name="bodyParameters"></param>
        /// <exception cref="HttpErrorException"></exception>
        /// <returns></returns>
        public Task<TResult> GetAsync<TResult>(IAuthenticatedUntappdCredentials credentials, string urlParameter = "", IDictionary<string, object> bodyParameters = null)
           where TResult : class,IAuthenticatedRequest, new()
        {
            var result = new TResult();
            return ConfigureRequest(credentials, result.EndPoint(urlParameter), bodyParameters)
            .ExecuteRequestAsync<TResult>();
        }
    }
}
