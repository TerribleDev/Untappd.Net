using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Untappd.Net.Request
{
    public abstract class AuthenticatedRequest
    {
        protected abstract string _EndPoint { get; }
        /// <summary>
        /// Pass in the parameter into the request...ie username, brewery, etc.
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        internal string EndPoint(string parameter)
        {
            return string.Format(_EndPoint, parameter);
        }
    }
}
