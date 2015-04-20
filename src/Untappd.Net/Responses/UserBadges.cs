using System.Collections.Generic;
using Newtonsoft.Json;
using Untappd.Net.Request;

namespace Untappd.Net.Responses.UserBadges
{

    public sealed class ResponseTime
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

    public class Media
    {

        [JsonProperty("badge_image_sm")]
        public string BadgeImageSm { get; set; }

        [JsonProperty("badge_image_md")]
        public string BadgeImageMd { get; set; }

        [JsonProperty("badge_image_lg")]
        public string BadgeImageLg { get; set; }
    }

    public class BadgePackProgress
    {

        [JsonProperty("completed")]
        public int Completed { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class Item
    {

        [JsonProperty("badge_id")]
        public int BadgeId { get; set; }

        [JsonProperty("user_badge_id")]
        public int UserBadgeId { get; set; }

        [JsonProperty("checkin_id")]
        public int CheckinId { get; set; }

        [JsonProperty("badge_name")]
        public string BadgeName { get; set; }

        [JsonProperty("badge_description")]
        public string BadgeDescription { get; set; }

        [JsonProperty("badge_hint")]
        public string BadgeHint { get; set; }

        [JsonProperty("badge_active_status")]
        public int BadgeActiveStatus { get; set; }

        [JsonProperty("media")]
        public Media Media { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("is_level")]
        public bool IsLevel { get; set; }

        [JsonProperty("category_id")]
        public int CategoryId { get; set; }

        [JsonProperty("levels")]
        public object Levels { get; set; }

        [JsonProperty("badge_pack")]
        public int BadgePack { get; set; }

        [JsonProperty("badge_pack_name")]
        public bool BadgePackName { get; set; }

        [JsonProperty("badge_pack_progress")]
        public BadgePackProgress BadgePackProgress { get; set; }
    }

    public class Response
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("sort")]
        public string Sort { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("items")]
        public IList<Item> Items { get; set; }
    }

    public class UserBadges : UnAuthenticatedRequest
    {
        protected override string _EndPoint { get { return "v4/user/badges/{0}"; } }
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("notifications")]
        public IList<object> Notifications { get; set; }

        [JsonProperty("response")]
        public Response Response { get; set; }
    }


}
