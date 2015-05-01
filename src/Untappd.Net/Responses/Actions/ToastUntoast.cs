using System;
using System.Collections.Generic;
using RestSharp;
using Untappd.Net.Request;

namespace Untappd.Net.Responses.Actions
{
    public class ToastUntoast : IAction
    {
        public Method RequestMethod { get; private set; }
        public IDictionary<string, object> BodyParameters { get; private set; }
        public string CheckinId { get; private set; }
        public string EndPoint { get { return string.Format("v4/checkin/toast/{0}", CheckinId); } }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="checkinId"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public ToastUntoast(string checkinId)
        {
            if (string.IsNullOrWhiteSpace(checkinId))
            {
                throw new ArgumentNullException("checkinId");
            }
            CheckinId = string.Copy(checkinId);
            BodyParameters = new Dictionary<string, object>();
            RequestMethod = Method.POST;
        }
    }
}
