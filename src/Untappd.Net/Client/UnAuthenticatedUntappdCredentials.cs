using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Untappd.Net.Client;

namespace Untappd.Client.Net
{
    public class UnAuthenticatedUntappdCredentials : UntappdCredentials, IUnAuthenticadedUntappdCredentials
    {
        /// <summary>
        /// UnAuthenticated request. Pass your API id and secret
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        public UnAuthenticatedUntappdCredentials(string clientId, string clientSecret)
            : base(clientId, clientSecret)
        {   
        }
    }
}
