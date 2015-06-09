using System;

namespace Untappd.Net.Request
{
    public abstract class BaseRequest
    {
        protected abstract string EndPoint_ { get; }
        /// <summary>
        /// Pass in the parameter into the request...ie username, brewery, etc.
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public string EndPoint(string parameter = "")
        {
            if (!string.IsNullOrEmpty(parameter))
            {
                parameter = $"/{parameter}";
                return string.Format(EndPoint_, parameter);
            }
            return string.Format(EndPoint_, string.Empty);
        }
    }
}
