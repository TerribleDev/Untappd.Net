using System.Collections.Generic;
using RestSharp;

namespace Untappd.Net.Request
{
    public interface IAction
    {
        Method RequestMethod { get; }
        string EndPoint { get; }
        IDictionary<string, object> BodyParameters { get; } 
    }
}
