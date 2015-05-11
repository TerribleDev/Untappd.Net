using System.Collections.Generic;
using Newtonsoft.Json;
using Untappd.Net.Request;

namespace Untappd.Net.Responses.UserInfo
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

    public class Stats
    {

        [JsonProperty("total_badges")]
        public int TotalBadges { get; set; }

        [JsonProperty("total_friends")]
        public int TotalFriends { get; set; }

        [JsonProperty("total_checkins")]
        public int TotalCheckins { get; set; }

        [JsonProperty("total_beers")]
        public int TotalBeers { get; set; }

        [JsonProperty("total_created_beers")]
        public int TotalCreatedBeers { get; set; }

        [JsonProperty("total_followings")]
        public int TotalFollowings { get; set; }

        [JsonProperty("total_photos")]
        public int TotalPhotos { get; set; }
    }

    public class Beer
    {

        [JsonProperty("bid")]
        public int Bid { get; set; }

        [JsonProperty("beer_name")]
        public string BeerName { get; set; }

        [JsonProperty("beer_label")]
        public string BeerLabel { get; set; }

        [JsonProperty("beer_abv")]
        public double BeerAbv { get; set; }

        [JsonProperty("beer_description")]
        public string BeerDescription { get; set; }

        [JsonProperty("beer_style")]
        public string BeerStyle { get; set; }

        [JsonProperty("auth_rating")]
        public double AuthRating { get; set; }

        [JsonProperty("wish_list")]
        public bool WishList { get; set; }
    }

    public class Contact
    {

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("facebook")]
        public string Facebook { get; set; }

        [JsonProperty("instagram")]
        public string Instagram { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Location
    {

        [JsonProperty("brewery_city")]
        public string BreweryCity { get; set; }

        [JsonProperty("brewery_state")]
        public string BreweryState { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }
    }

    public class Brewery
    {

        [JsonProperty("brewery_id")]
        public int BreweryId { get; set; }

        [JsonProperty("brewery_name")]
        public string BreweryName { get; set; }

        [JsonProperty("brewery_slug")]
        public string BrewerySlug { get; set; }

        [JsonProperty("brewery_label")]
        public string BreweryLabel { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("contact")]
        public Contact Contact { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("brewery_active")]
        public int BreweryActive { get; set; }
    }

    public class Item
    {

        [JsonProperty("beer")]
        public Beer Beer { get; set; }

        [JsonProperty("brewery")]
        public Brewery Brewery { get; set; }
    }

    public class RecentBrews
    {

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("items")]
        public IList<Item> Items { get; set; }
    }

    public class Contact2
    {

        [JsonProperty("facebook")]
        public string Facebook { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }
    }

    public class User2
    {

        [JsonProperty("uid")]
        public int Uid { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("is_supporter")]
        public int IsSupporter { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("relationship")]
        public string Relationship { get; set; }

        [JsonProperty("user_avatar")]
        public string UserAvatar { get; set; }

        [JsonProperty("is_private")]
        public int IsPrivate { get; set; }

        [JsonProperty("contact")]
        public Contact2 Contact { get; set; }
    }

    public class Beer2
    {

        [JsonProperty("bid")]
        public int Bid { get; set; }

        [JsonProperty("beer_name")]
        public string BeerName { get; set; }

        [JsonProperty("beer_label")]
        public string BeerLabel { get; set; }

        [JsonProperty("beer_style")]
        public string BeerStyle { get; set; }

        [JsonProperty("beer_abv")]
        public double BeerAbv { get; set; }

        [JsonProperty("auth_rating")]
        public double AuthRating { get; set; }

        [JsonProperty("wish_list")]
        public bool WishList { get; set; }

        [JsonProperty("beer_active")]
        public int BeerActive { get; set; }
    }

    public class Contact3
    {

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("facebook")]
        public string Facebook { get; set; }

        [JsonProperty("instagram")]
        public string Instagram { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Location2
    {

        [JsonProperty("brewery_city")]
        public string BreweryCity { get; set; }

        [JsonProperty("brewery_state")]
        public string BreweryState { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }
    }

    public class Brewery2
    {

        [JsonProperty("brewery_id")]
        public int BreweryId { get; set; }

        [JsonProperty("brewery_name")]
        public string BreweryName { get; set; }

        [JsonProperty("brewery_slug")]
        public string BrewerySlug { get; set; }

        [JsonProperty("brewery_label")]
        public string BreweryLabel { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("contact")]
        public Contact3 Contact { get; set; }

        [JsonProperty("location")]
        public Location2 Location { get; set; }

        [JsonProperty("brewery_active")]
        public int BreweryActive { get; set; }
    }

    public class Item3
    {

        [JsonProperty("category_name")]
        public string CategoryName { get; set; }

        [JsonProperty("category_id")]
        public string CategoryId { get; set; }

        [JsonProperty("is_primary")]
        public bool IsPrimary { get; set; }
    }

    public class Categories
    {

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("items")]
        public IList<Item3> Items { get; set; }
    }

    public class Location3
    {

        [JsonProperty("venue_address")]
        public string VenueAddress { get; set; }

        [JsonProperty("venue_city")]
        public string VenueCity { get; set; }

        [JsonProperty("venue_state")]
        public string VenueState { get; set; }

        [JsonProperty("venue_country")]
        public string VenueCountry { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }
    }

    public class Contact4
    {

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("venue_url")]
        public string VenueUrl { get; set; }
    }

    public class Foursquare
    {

        [JsonProperty("foursquare_id")]
        public string FoursquareId { get; set; }

        [JsonProperty("foursquare_url")]
        public string FoursquareUrl { get; set; }
    }

    public class VenueIcon
    {

        [JsonProperty("sm")]
        public string Sm { get; set; }

        [JsonProperty("md")]
        public string Md { get; set; }

        [JsonProperty("lg")]
        public string Lg { get; set; }
    }

    public class Venue
    {

        [JsonProperty("venue_id")]
        public int VenueId { get; set; }

        [JsonProperty("venue_name")]
        public string VenueName { get; set; }

        [JsonProperty("primary_category")]
        public string PrimaryCategory { get; set; }

        [JsonProperty("parent_category_id")]
        public string ParentCategoryId { get; set; }

        [JsonProperty("categories")]
        public Categories Categories { get; set; }

        [JsonProperty("location")]
        public Location3 Location { get; set; }

        [JsonProperty("contact")]
        public Contact4 Contact { get; set; }

        [JsonProperty("public_venue")]
        public bool PublicVenue { get; set; }

        [JsonProperty("foursquare")]
        public Foursquare Foursquare { get; set; }

        [JsonProperty("venue_icon")]
        public VenueIcon VenueIcon { get; set; }
    }

    public class Comments
    {

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("items")]
        public IList<object> Items { get; set; }
    }

    public class User3
    {

        [JsonProperty("uid")]
        public int Uid { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("user_avatar")]
        public string UserAvatar { get; set; }

        [JsonProperty("user_link")]
        public string UserLink { get; set; }

        [JsonProperty("account_type")]
        public string AccountType { get; set; }

        [JsonProperty("brewery_details")]
        public IList<object> BreweryDetails { get; set; }
    }

    public class Item4
    {

        [JsonProperty("uid")]
        public int Uid { get; set; }

        [JsonProperty("user")]
        public User3 User { get; set; }

        [JsonProperty("like_id")]
        public int LikeId { get; set; }

        [JsonProperty("like_owner")]
        public bool LikeOwner { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class Toasts
    {

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("auth_toast")]
        public bool AuthToast { get; set; }

        [JsonProperty("items")]
        public IList<Item4> Items { get; set; }
    }

    public class Photo
    {

        [JsonProperty("photo_img_sm")]
        public string PhotoImgSm { get; set; }

        [JsonProperty("photo_img_md")]
        public string PhotoImgMd { get; set; }

        [JsonProperty("photo_img_lg")]
        public string PhotoImgLg { get; set; }

        [JsonProperty("photo_img_og")]
        public string PhotoImgOg { get; set; }
    }

    public class Item5
    {

        [JsonProperty("photo_id")]
        public int PhotoId { get; set; }

        [JsonProperty("photo")]
        public Photo Photo { get; set; }
    }

    public class Media
    {

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("items")]
        public IList<Item5> Items { get; set; }
    }

    public class Source
    {

        [JsonProperty("app_name")]
        public string AppName { get; set; }

        [JsonProperty("app_website")]
        public string AppWebsite { get; set; }
    }

    public class BadgeImage
    {

        [JsonProperty("sm")]
        public string Sm { get; set; }

        [JsonProperty("md")]
        public string Md { get; set; }

        [JsonProperty("lg")]
        public string Lg { get; set; }
    }

    public class Item6
    {

        [JsonProperty("badge_id")]
        public int BadgeId { get; set; }

        [JsonProperty("user_badge_id")]
        public int UserBadgeId { get; set; }

        [JsonProperty("badge_name")]
        public string BadgeName { get; set; }

        [JsonProperty("badge_description")]
        public string BadgeDescription { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("badge_image")]
        public BadgeImage BadgeImage { get; set; }
    }

    public class Badges
    {

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("items")]
        public IList<Item6> Items { get; set; }
    }

    public class Item2
    {

        [JsonProperty("checkin_id")]
        public int CheckinId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("checkin_comment")]
        public string CheckinComment { get; set; }

        [JsonProperty("rating_score")]
        public double RatingScore { get; set; }

        [JsonProperty("user")]
        public User2 User { get; set; }

        [JsonProperty("beer")]
        public Beer2 Beer { get; set; }

        [JsonProperty("brewery")]
        public Brewery2 Brewery { get; set; }

        [JsonProperty("venue")]
        [JsonConverter(typeof(SingleObjectArrayConverter<Venue>))]
        public Venue Venue { get; set; }

        [JsonProperty("comments")]
        public Comments Comments { get; set; }

        [JsonProperty("toasts")]
        public Toasts Toasts { get; set; }

        [JsonProperty("media")]
        public Media Media { get; set; }

        [JsonProperty("source")]
        public Source Source { get; set; }

        [JsonProperty("badges")]
        public Badges Badges { get; set; }
    }

    public class Checkins
    {

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("items")]
        public IList<Item2> Items { get; set; }
    }

    public class Photo2
    {

        [JsonProperty("photo_img_sm")]
        public string PhotoImgSm { get; set; }

        [JsonProperty("photo_img_md")]
        public string PhotoImgMd { get; set; }

        [JsonProperty("photo_img_lg")]
        public string PhotoImgLg { get; set; }

        [JsonProperty("photo_img_og")]
        public string PhotoImgOg { get; set; }
    }

    public class User4
    {

        [JsonProperty("uid")]
        public int Uid { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_avatar")]
        public string UserAvatar { get; set; }

        [JsonProperty("account_type")]
        public string AccountType { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Beer3
    {

        [JsonProperty("bid")]
        public int Bid { get; set; }

        [JsonProperty("beer_name")]
        public string BeerName { get; set; }

        [JsonProperty("beer_label")]
        public string BeerLabel { get; set; }

        [JsonProperty("beer_abv")]
        public double BeerAbv { get; set; }

        [JsonProperty("beer_style")]
        public string BeerStyle { get; set; }

        [JsonProperty("beer_description")]
        public string BeerDescription { get; set; }

        [JsonProperty("auth_rating")]
        public double AuthRating { get; set; }

        [JsonProperty("wish_list")]
        public bool WishList { get; set; }
    }

    public class Contact5
    {

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("facebook")]
        public string Facebook { get; set; }

        [JsonProperty("instagram")]
        public string Instagram { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Location4
    {

        [JsonProperty("brewery_city")]
        public string BreweryCity { get; set; }

        [JsonProperty("brewery_state")]
        public string BreweryState { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }
    }

    public class Brewery3
    {

        [JsonProperty("brewery_id")]
        public int BreweryId { get; set; }

        [JsonProperty("brewery_name")]
        public string BreweryName { get; set; }

        [JsonProperty("brewery_slug")]
        public string BrewerySlug { get; set; }

        [JsonProperty("brewery_label")]
        public string BreweryLabel { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("contact")]
        public Contact5 Contact { get; set; }

        [JsonProperty("location")]
        public Location4 Location { get; set; }

        [JsonProperty("brewery_active")]
        public int BreweryActive { get; set; }
    }

    public class Item8
    {

        [JsonProperty("category_name")]
        public string CategoryName { get; set; }

        [JsonProperty("category_id")]
        public string CategoryId { get; set; }

        [JsonProperty("is_primary")]
        public bool IsPrimary { get; set; }
    }

    public class Categories2
    {

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("items")]
        public IList<Item8> Items { get; set; }
    }

    public class Location5
    {

        [JsonProperty("venue_address")]
        public string VenueAddress { get; set; }

        [JsonProperty("venue_city")]
        public string VenueCity { get; set; }

        [JsonProperty("venue_state")]
        public string VenueState { get; set; }

        [JsonProperty("venue_country")]
        public string VenueCountry { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }
    }

    public class Contact6
    {

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("venue_url")]
        public string VenueUrl { get; set; }
    }

    public class Foursquare2
    {

        [JsonProperty("foursquare_id")]
        public string FoursquareId { get; set; }

        [JsonProperty("foursquare_url")]
        public string FoursquareUrl { get; set; }
    }

    public class VenueIcon2
    {

        [JsonProperty("sm")]
        public string Sm { get; set; }

        [JsonProperty("md")]
        public string Md { get; set; }

        [JsonProperty("lg")]
        public string Lg { get; set; }
    }

    public class Venue2
    {

        [JsonProperty("venue_id")]
        public int VenueId { get; set; }

        [JsonProperty("venue_name")]
        public string VenueName { get; set; }

        [JsonProperty("primary_category")]
        public string PrimaryCategory { get; set; }

        [JsonProperty("parent_category_id")]
        public string ParentCategoryId { get; set; }

        [JsonProperty("categories")]
        public Categories2 Categories { get; set; }

        [JsonProperty("location")]
        public Location5 Location { get; set; }

        [JsonProperty("contact")]
        public Contact6 Contact { get; set; }

        [JsonProperty("public_venue")]
        public bool PublicVenue { get; set; }

        [JsonProperty("foursquare")]
        public Foursquare2 Foursquare { get; set; }

        [JsonProperty("venue_icon")]
        public VenueIcon2 VenueIcon { get; set; }
    }

    public class Item7
    {

        [JsonProperty("photo_id")]
        public int PhotoId { get; set; }

        [JsonProperty("photo")]
        public Photo2 Photo { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("checkin_id")]
        public int CheckinId { get; set; }

        [JsonProperty("user")]
        public User4 User { get; set; }

        [JsonProperty("beer")]
        public Beer3 Beer { get; set; }

        [JsonProperty("brewery")]
        public Brewery3 Brewery { get; set; }

        [JsonProperty("venue")]
        public Venue2 Venue { get; set; }
    }

    public class Media2
    {

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("items")]
        public IList<Item7> Items { get; set; }
    }

    public class Contact7
    {

        [JsonProperty("facebook")]
        public int Facebook { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }
    }

    public class Badge
    {

        [JsonProperty("badges_to_facebook")]
        public int BadgesToFacebook { get; set; }

        [JsonProperty("badges_to_twitter")]
        public int BadgesToTwitter { get; set; }
    }

    public class Checkin
    {

        [JsonProperty("checkin_to_facebook")]
        public int CheckinToFacebook { get; set; }

        [JsonProperty("checkin_to_twitter")]
        public int CheckinToTwitter { get; set; }

        [JsonProperty("checkin_to_foursquare")]
        public int CheckinToFoursquare { get; set; }
    }

    public class Navigation
    {

        [JsonProperty("default_to_checkin")]
        public int DefaultToCheckin { get; set; }
    }

    public class Settings
    {

        [JsonProperty("badge")]
        public Badge Badge { get; set; }

        [JsonProperty("checkin")]
        [JsonConverter(typeof(SingleObjectArrayConverter<Checkin>))]
        public Checkin Checkin { get; set; }

        [JsonProperty("navigation")]
        public Navigation Navigation { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }
    }

    public class User
    {

        [JsonProperty("uid")]
        public int Uid { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_avatar")]
        public string UserAvatar { get; set; }

        [JsonProperty("user_avatar_hd")]
        public string UserAvatarHd { get; set; }

        [JsonProperty("user_cover_photo")]
        public string UserCoverPhoto { get; set; }

        [JsonProperty("user_cover_photo_offset")]
        public int UserCoverPhotoOffset { get; set; }

        [JsonProperty("is_private")]
        public int IsPrivate { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("is_supporter")]
        public int IsSupporter { get; set; }

        [JsonProperty("relationship")]
        public string Relationship { get; set; }

        [JsonProperty("untappd_url")]
        public string UntappdUrl { get; set; }

        [JsonProperty("account_type")]
        public string AccountType { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("recent_brews")]
        public RecentBrews RecentBrews { get; set; }

        [JsonProperty("checkins")]
        [JsonConverter(typeof(SingleObjectArrayConverter<Checkins>))]
        public Checkins Checkins { get; set; }

        [JsonProperty("media")]
        public Media2 Media { get; set; }

        [JsonProperty("contact")]
        public Contact7 Contact { get; set; }

        [JsonProperty("date_joined")]
        public string DateJoined { get; set; }

        [JsonProperty("settings")]
        public Settings Settings { get; set; }
    }

    public class Response
    {

        [JsonProperty("user")]
        public User User { get; set; }
    }

    public class UserInfo : BasicRequest, IAuthenticatedRequest, IUnAuthenticatedRequest
    {
        protected override string _EndPoint { get { return "v4/user/info{0}"; } }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("notifications")]
        [JsonConverter(typeof(SingleObjectArrayConverter<Notifications>))]
        public Notifications Notifications { get; set; }

        [JsonProperty("response")]
        public Response Response { get; set; }
    }
}