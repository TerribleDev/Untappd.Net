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
        public Method RequestMethod { get{ return Method.POST;} }
        public string EndPoint { get { return "v4/checkin/add"; } }

        public IDictionary<string, object> BodyParameters
        {
            get
            {
                var dict = new Dictionary<string, object>
                {
                    {"gmt_offset", gmt_offset},
                    {"timezone", timezone},
                    {"bid", bid}
                };
                if (geolat.HasValue)
                {
                    dict.Add("geolat", geolat.Value);
                }
                if (geolng.HasValue)
                {
                    dict.Add("geolng", geolng.Value);
                }
                if (!string.IsNullOrWhiteSpace(shout) && shout.Length <= 140)
                {
                    dict.Add("shout", shout);
                }
                if (rating > 0 && rating < 6)
                {
                    dict.Add("rating", rating);
                }
                return dict;
            }
        }

        public string gmt_offset { get; private set; }
        public string timezone { get; private set; }
        public int bid { get; private set; }
        public int? geolat { get; set; }
        public int? geolng { get; set; }

        public string shout
        {
            get { return _shout; }
            set
            {
                if (value.Length > 140)
                {
                    throw new ArgumentOutOfRangeException("value", value,"Shout can be no more than 140 characters");
                }
                _shout = value;
            }
        }

        public short rating
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


        public CheckIn(string gmt_offset, string timezone, int bid)
        {
            if (string.IsNullOrWhiteSpace(gmt_offset))
            {
                throw new ArgumentNullException("gmt_offset");
            }
            if (string.IsNullOrWhiteSpace(timezone))
            {
                throw new ArgumentNullException("timezone");
            }
            this.gmt_offset = string.Copy(gmt_offset);
            this.timezone = string.Copy(timezone);
            this.bid = bid;
        }
    }
}
