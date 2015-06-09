using System;
using Newtonsoft.Json;
using RestSharp;

namespace Untappd.Net.Exception
{
    public sealed class HttpErrorException : BaseUntappdException
    {
        public override string Message
        {
            get
            {
                return _message;
            }
        }

        readonly string _message;
        public HttpErrorException(IRestRequest request, IRestResponse response)
        {
            var code = (int) response.StatusCode;
            if (code == 200)
            {
                throw new BaseUntappdException(
                    "HttpError is being throw with a 200 error. Something has gone horribly wrong");
            }

            _message = $"HttpError {code} was returned with Message: {Environment.NewLine}{                response.ErrorMessage}";
            Data.Add("Request Object", JsonConvert.SerializeObject(request));
            Data.Add("Response Object", JsonConvert.SerializeObject(response));
        }
    }
}
