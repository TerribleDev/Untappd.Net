using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
