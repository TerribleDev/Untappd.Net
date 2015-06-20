using System;
using Newtonsoft.Json;
using RestSharp;

namespace Untappd.Net.Exception
{
    [Serializable]
    public sealed class HttpErrorException : BaseUntappdException
    {
        public override string Message
        {
            get
            {
                return _message;
            }
        }

        private readonly string _message;
        public HttpErrorException(IRestRequest request, IRestResponse response)
        {
            if(request == null)
            {
                throw new ArgumentNullException("request");
            }
            if (response == null)
            {
                 throw new ArgumentNullException("response");
            }
            var code = (int) response.StatusCode;
            if (code == 200)
            {
                throw new BaseUntappdException(
                    "HttpError is being throw with a 200 error. Something has gone horribly wrong");
            }

            _message = string.Format("HttpError {0} was returned with Message: {1}{2}", code, Environment.NewLine,
                response.ErrorMessage);
            Data.Add("Request Object", JsonConvert.SerializeObject(request));
            Data.Add("Response Object", JsonConvert.SerializeObject(response));
        }
    }
}
