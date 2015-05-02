using System;
using System.Collections.Generic;
using RestSharp;
using Untappd.Net.Request;

namespace Untappd.Net.Responses.Actions
{
    public class AddComment : IAction
    {
        public Method RequestMethod { get {return Method.POST;} }
        public string EndPoint { get; private set; }
        public IDictionary<string, object> BodyParameters { get; private set; }
        public AddComment(string checkinId, string shout)
        {
            if (string.IsNullOrWhiteSpace(checkinId))
            {
                throw new ArgumentNullException("checkinId");
            }
            if (string.IsNullOrWhiteSpace(shout))
            {
                throw new ArgumentNullException("shout");
            }
            if (shout.Length > 140)
            {
                throw new ArgumentOutOfRangeException("shout", shout, "Shout cannot be more than 140 characters");
            }
            EndPoint = string.Format("v4/checkin/addcomment/{0}", checkinId);
            BodyParameters = new Dictionary<string, object> {{shout, shout}};

        }
    }
}
