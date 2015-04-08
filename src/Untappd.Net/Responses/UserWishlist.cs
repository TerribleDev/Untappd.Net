using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Untappd.Net.Request;

namespace Untappd.Net.Responses.UserWishlist
{

    public class ResponseTime
    {

        [JsonProperty("time")]
        public double Time { get; set; }

        [JsonProperty("measure")]
        public string Measure { get; set; }
    }

    public class InitTime
    {

        [JsonProperty("time")]
        public double Time { get; set; }

        [JsonProperty("measure")]
        public string Measure { get; set; }
    }

    public class Meta
    {

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("response_time")]
        public ResponseTime ResponseTime { get; set; }

        [JsonProperty("init_time")]
        public InitTime InitTime { get; set; }
    }

    public class Beers
    {

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("items")]
        public IList<object> Items { get; set; }
    }

    public class Response
    {

        [JsonProperty("sort")]
        public string Sort { get; set; }

        [JsonProperty("sort_english")]
        public string SortEnglish { get; set; }

        [JsonProperty("type_id")]
        public int TypeId { get; set; }

        [JsonProperty("beers")]
        public Beers Beers { get; set; }
    }

    public class UserWishList : UnAuthenticatedRequest
    {
        protected override string _EndPoint { get { return "/v4/user/wishlist/{0}"; } }
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("notifications")]
        public IList<object> Notifications { get; set; }

        [JsonProperty("response")]
        public Response Response { get; set; }
    }


}
