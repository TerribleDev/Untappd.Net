using System;
using System.Collections.Generic;
using RestSharp;
using Untappd.Net.Request;

namespace Untappd.Net.Responses.Actions
{
    public class AcceptFriend : IAction
    {
        public Method RequestMethod { get { return Method.GET; } }
        public string EndPoint { get; private set; }
        public IDictionary<string, object> BodyParameters { get { return new Dictionary<string, object>(); } }
        public AcceptFriend(string target_id)
        {
            if (string.IsNullOrWhiteSpace(target_id))
            {
                throw new ArgumentNullException(nameof(target_id));
            }
            EndPoint = $"v4/friend/accept/{target_id}";
        }
    }
}
