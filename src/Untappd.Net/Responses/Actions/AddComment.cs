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
                throw new ArgumentNullException(nameof(checkinId));
            }
            if (string.IsNullOrWhiteSpace(shout))
            {
                throw new ArgumentNullException(nameof(shout));
            }
            if (shout.Length > 140)
            {
                throw new ArgumentOutOfRangeException(nameof(shout), shout, "Shout cannot be more than 140 characters");
            }
            EndPoint = $"v4/checkin/addcomment/{checkinId}";
            BodyParameters = new Dictionary<string, object> {{shout, shout}};

        }
    }
}
