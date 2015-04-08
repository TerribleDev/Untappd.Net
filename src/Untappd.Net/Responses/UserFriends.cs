using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Untappd.Net.Request;

namespace Untappd.Net.Responses.UserFriends
{

    public class UserFriendsRootobject : BaseRequest
    {
        protected override string _EndPoint { get { return "v4/user/friends/{0}"; } }
        public int count { get; set; }
        public Item[] items { get; set; }
    }

    public class Item
    {
        public string friendship_hash { get; set; }
        public string created_at { get; set; }
        public User user { get; set; }
        public Mutual_Friends mutual_friends { get; set; }
    }

    public class User
    {
        public int uid { get; set; }
        public string user_name { get; set; }
        public string location { get; set; }
        public string bio { get; set; }
        public int is_supporter { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string relationship { get; set; }
        public string user_avatar { get; set; }
    }

    public class Mutual_Friends
    {
        public int count { get; set; }
        public object[] items { get; set; }
    }

}
