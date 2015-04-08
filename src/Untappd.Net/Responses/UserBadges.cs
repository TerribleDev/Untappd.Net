using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Untappd.Net.Request;

namespace Untappd.Net.Responses.UserBadges
{

    public class UserBadgesRootobject : BaseRequest
    {
        public string type { get; set; }
        public string sort { get; set; }
        public int count { get; set; }
        public Item[] items { get; set; }
        protected override string _EndPoint { get { return "v4/user/badges/{0}"; } }
    }

    public class Item
    {
        public int user_badge_id { get; set; }
        public int badge_id { get; set; }
        public int checkin_id { get; set; }
        public string badge_name { get; set; }
        public string badge_description { get; set; }
        public int badge_active_status { get; set; }
        public Media media { get; set; }
        public string created_at { get; set; }
        public bool is_level { get; set; }
        public int category_id { get; set; }
        public Levels levels { get; set; }
    }

    public class Media
    {
        public string badge_image_sm { get; set; }
        public string badge_image_md { get; set; }
        public string badge_image_lg { get; set; }
    }

    public class Levels
    {
        public int count { get; set; }
        public Item1[] items { get; set; }
    }

    public class Item1
    {
        public int actual_badge_id { get; set; }
        public int badge_id { get; set; }
        public int checkin_id { get; set; }
        public string badge_name { get; set; }
        public string badge_description { get; set; }
        public Media1 media { get; set; }
        public string created_at { get; set; }
    }

    public class Media1
    {
        public string badge_image_sm { get; set; }
        public string badge_image_md { get; set; }
        public string badge_image_lg { get; set; }
    }

}
