using System.Collections.Generic;
using RestSharp;
using Untappd.Net.Request;

namespace Untappd.Net.Responses.Actions
{
    public class AddToWishList : IAction
    {
        public Method RequestMethod { get {return Method.GET;} }
        public string EndPoint { get { return "v4/user/wishlist/add"; } }
        public IDictionary<string, object> BodyParameters { get; private set; }
        public AddToWishList(int beerId)
        {
            BodyParameters = new Dictionary<string, object> { { "bid", beerId } };

        }
    }
}
