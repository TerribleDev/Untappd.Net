using System;
using System.Collections.Generic;
using RestSharp;
using Untappd.Net.Request;

namespace Untappd.Net.Responses.Actions
{
	public class RemoveFriend : IAction
	{
		public Method RequestMethod { get { return Method.GET; } }
		public string EndPoint { get; private set; }
		public IDictionary<string, object> BodyParameters { get { return new Dictionary<string, object>(); } }

		public RemoveFriend(string target_id)
		{
			if (string.IsNullOrWhiteSpace(target_id))
			{
				throw new ArgumentNullException("target_id");
			}
			EndPoint = string.Format("v4/friend/reject/{0}", target_id);
		}
	}
}