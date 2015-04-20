using Untappd.Net.Exception;

namespace Untappd.Net.Request
{
    public abstract class AuthenticatedRequest
    {
        protected abstract string _EndPoint { get; }
        /// <summary>
        /// Pass in the url parameter into the request...ie username, brewery, etc.
        /// </summary>
        /// <param name="parameter">this can be null if request has no url params</param>
        /// <returns></returns>
        internal string EndPoint(string parameter)
        {
            if (string.IsNullOrWhiteSpace(_EndPoint))
            {
                throw new EndpointConfigurationException();
            }
            return string.Format(_EndPoint, parameter);
        }
    }
}
