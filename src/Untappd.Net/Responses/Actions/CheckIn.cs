using System;
using System.Collections.Generic;
using RestSharp;
using Untappd.Net.Request;

namespace Untappd.Net.Responses.Actions
{
	public class CheckIn : IAction
	{
		private short _rating;
		private string _shout;
		public Method RequestMethod { get { return Method.POST; } }
		public string EndPoint { get { return "v4/checkin/add"; } }

		public IDictionary<string, object> BodyParameters
		{
			get
			{
				var dict = new Dictionary<string, object>
				{
					{"gmt_offset", GmtOffset},
					{"timezone", Timezone},
					{"bid", Bid}
				};
				if (Geolat.HasValue)
				{
					dict.Add("geolat", Geolat.Value);
				}
				if (Geolng.HasValue)
				{
					dict.Add("geolng", Geolng.Value);
				}
				if (!string.IsNullOrWhiteSpace(Shout) && Shout.Length <= 140)
				{
					dict.Add("shout", Shout);
				}
				if (Rating > 0 && Rating < 6)
				{
					dict.Add("rating", Rating);
				}
				return dict;
			}
		}

		public string GmtOffset { get; private set; }
		public string Timezone { get; private set; }
		public int Bid { get; private set; }
		public int? Geolat { get; set; }
		public int? Geolng { get; set; }

		public string Shout
		{
			get { return _shout; }
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				if (value.Length > 140)
				{
					throw new ArgumentOutOfRangeException("value", value, "Shout can be no more than 140 characters");
				}
				_shout = string.Copy(value);
			}
		}

		public short Rating
		{
			get { return _rating; }
			set
			{
				if (value < 1 || value > 5)
				{
					throw new ArgumentOutOfRangeException("value", value, "Ratings should be between 1 and 5");
				}
				_rating = value;
			}
		}

		public CheckIn(string gmtOffset, string timezone, int bid)
		{
			if (string.IsNullOrWhiteSpace(gmtOffset))
			{
				throw new ArgumentNullException("gmtOffset");
			}
			if (string.IsNullOrWhiteSpace(timezone))
			{
				throw new ArgumentNullException("timezone");
			}
			GmtOffset = string.Copy(gmtOffset);
			Timezone = string.Copy(timezone);
			Bid = bid;
		}
	}
}