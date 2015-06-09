using System.Collections.Generic;
using Newtonsoft.Json;
using Untappd.Net.Request;

namespace Untappd.Net.Responses.UserFriends
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

    public class UnreadCount
    {

        [JsonProperty("comments")]
        public int Comments { get; set; }

        [JsonProperty("toasts")]
        public int Toasts { get; set; }

        [JsonProperty("friends")]
        public int Friends { get; set; }

        [JsonProperty("messages")]
        public int Messages { get; set; }

        [JsonProperty("news")]
        public int News { get; set; }
    }

    public class Notifications
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("unread_count")]
        public UnreadCount UnreadCount { get; set; }
    }

    public class User
    {

        [JsonProperty("uid")]
        public int Uid { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("is_supporter")]
        public int IsSupporter { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("relationship")]
        public string Relationship { get; set; }

        [JsonProperty("user_avatar")]
        public string UserAvatar { get; set; }
    }

    public class MutualFriends
    {

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("items")]
        public IList<object> Items { get; set; }
    }

    public class Item
    {

        [JsonProperty("friendship_hash")]
        public string FriendshipHash { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("mutual_friends")]
        public MutualFriends MutualFriends { get; set; }
    }

    public class Response
    {

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("items")]
        public IList<Item> Items { get; set; }
    }

    public class UserFriends : BaseRequest, IAuthenticatedRequest, IUnAuthenticatedRequest
    {
        protected override string EndPoint_ { get { return "v4/user/friends{0}"; } }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("notifications")]
        [JsonConverter(typeof(SingleObjectArrayConverter<Notifications>))]
        public Notifications Notifications { get; set; }

        [JsonProperty("response")]
        public Response Response { get; set; }
    }
}
