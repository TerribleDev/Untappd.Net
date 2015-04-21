﻿using System;
namespace Untappd.Net.Request
{
    public abstract class BasicRequest
    {
        protected abstract string _EndPoint { get; }
        /// <summary>
        /// Pass in the parameter into the request...ie username, brewery, etc.
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public string EndPoint(string parameter = "")
        {
            if (!String.IsNullOrEmpty(parameter))
            {
                parameter = string.Format("/{0}", parameter);
                return string.Format(_EndPoint, parameter);
            }
            return string.Format(_EndPoint, string.Empty);
        }
    }
}