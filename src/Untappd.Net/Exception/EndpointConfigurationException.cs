using System;

namespace Untappd.Net.Exception
{
    [Serializable]
    public class EndpointConfigurationException : BaseUntappdException
    {
        /// <summary>
        /// Called when a class has an empty endpoint
        /// </summary>
        /// <param name="type"></param>
        public EndpointConfigurationException()
            :base("Invalid endpoint configured")
        {
            
        }
    }
}
