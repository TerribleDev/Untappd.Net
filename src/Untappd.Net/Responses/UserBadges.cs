using System.Collections.Generic;
using Newtonsoft.Json;
using Untappd.Net.Request;

namespace Untappd.Net.Responses.UserBadges
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

    public class BadgeLevel
    {
        [JsonProperty("actual_badge_id")]
        public int ActualBadgeId { get; set; }

        [JsonProperty("badge_id")]
        public int BadgeId { get; set; }

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
    }

    public class Levels
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("items")]
        public IList<BadgeLevel> Items { get; set; }
    }

    public class Item
    {

        [JsonProperty("user_badge_id")]
        public int UserBadgeId { get; set; }

        [JsonProperty("badge_id")]
        public int BadgeId { get; set; }

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

        [JsonProperty("badge_type")]
        public string BadgeType { get; set; }

        [JsonProperty("has_badge")]
        public bool HasBadge { get; set; }

        [JsonProperty("category_id")]
        public int CategoryId { get; set; }

        /// <summary>
        /// Issue with bad json responses
        /// levels might come as object levels : { ... }
        /// or an empty array levels : []
        /// </summary>
        [JsonProperty(PropertyName = "levels")]
        [JsonConverter(typeof(SingleObjectArrayConverter<Levels>))]
        public Levels Levels { get; set; }

        [JsonProperty("badge_pack")]
        public bool BadgePack { get; set; }

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

    /// <summary>
    /// jsonutils.com fails to parse Untappd response for this requests
    /// It fails getting the badge levels.
    /// added manually.
    /// </summary>
    public class UserBadges : BasicRequest, IAuthenticatedRequest, IUnAuthenticatedRequest
    {
        protected override string _EndPoint { get { return "v4/user/badges{0}"; } }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("notifications")]
        public Notifications Notifications { get; set; }

        [JsonProperty("response")]
        public Response Response { get; set; }
    }
}