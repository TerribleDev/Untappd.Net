using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private readonly string _message;
        public HttpErrorException(IRestRequest request, IRestResponse response)
        {
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
