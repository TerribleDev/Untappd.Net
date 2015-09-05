using System.Collections.Generic;
using Newtonsoft.Json;
using Untappd.Net.Request;

namespace Untappd.Net.Responses.BeerInfo
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
		[JsonProperty("total_count")]
		public int TotalCount { get; set; }

		[JsonProperty("monthly_count")]
		public int MonthlyCount { get; set; }

		[JsonProperty("total_user_count")]
		public int TotalUserCount { get; set; }

		[JsonProperty("user_count")]
		public int UserCount { get; set; }
	}

	public class Contact
	{
		[JsonProperty("twitter")]
		public string Twitter { get; set; }

		[JsonProperty("facebook")]
		public string Facebook { get; set; }

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

		[JsonProperty("brewery_label")]
		public string BreweryLabel { get; set; }

		[JsonProperty("country_name")]
		public string CountryName { get; set; }

		[JsonProperty("contact")]
		[JsonConverter(typeof(SingleObjectArrayConverter<Contact>))]
		public Contact Contact { get; set; }

		[JsonProperty("location")]
		public Location Location { get; set; }
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

	public class Beer2
	{
		[JsonProperty("bid")]
		public int Bid { get; set; }

		[JsonProperty("beer_name")]
		public string BeerName { get; set; }

		[JsonProperty("beer_label")]
		public string BeerLabel { get; set; }

		[JsonProperty("beer_abv")]
		public double BeerAbv { get; set; }

		[JsonProperty("beer_ibu")]
		public int BeerIbu { get; set; }

		[JsonProperty("beer_slug")]
		public string BeerSlug { get; set; }

		[JsonProperty("beer_description")]
		public string BeerDescription { get; set; }

		[JsonProperty("is_in_production")]
		public int IsInProduction { get; set; }

		[JsonProperty("beer_style_id")]
		public int BeerStyleId { get; set; }

		[JsonProperty("beer_style")]
		public string BeerStyle { get; set; }

		[JsonProperty("auth_rating")]
		public double AuthRating { get; set; }

		[JsonProperty("wish_list")]
		public bool WishList { get; set; }

		[JsonProperty("beer_active")]
		public int BeerActive { get; set; }
	}

	public class Contact2
	{
		[JsonProperty("twitter")]
		public string Twitter { get; set; }

		[JsonProperty("facebook")]
		public string Facebook { get; set; }

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
		[JsonConverter(typeof(SingleObjectArrayConverter<Contact2>))]
		public Contact2 Contact { get; set; }

		[JsonProperty("location")]
		public Location2 Location { get; set; }

		[JsonProperty("brewery_active")]
		public int BreweryActive { get; set; }
	}

	public class User
	{
		[JsonProperty("uid")]
		public int Uid { get; set; }

		[JsonProperty("user_name")]
		public string UserName { get; set; }

		[JsonProperty("first_name")]
		public string FirstName { get; set; }

		[JsonProperty("last_name")]
		public string LastName { get; set; }

		[JsonProperty("user_avatar")]
		public string UserAvatar { get; set; }

		[JsonProperty("relationship")]
		public string Relationship { get; set; }

		[JsonProperty("is_private")]
		public int IsPrivate { get; set; }
	}

	public class Item
	{
		[JsonProperty("photo_id")]
		public int PhotoId { get; set; }

		[JsonProperty("photo")]
		public Photo Photo { get; set; }

		[JsonProperty("created_at")]
		public string CreatedAt { get; set; }

		[JsonProperty("checkin_id")]
		public int CheckinId { get; set; }

		[JsonProperty("beer")]
		public Beer2 Beer { get; set; }

		[JsonProperty("brewery")]
		public Brewery2 Brewery { get; set; }

		[JsonProperty("user")]
		public User User { get; set; }

		[JsonProperty("venue")]
		public IList<object> Venue { get; set; }
	}

	public class Media
	{
		[JsonProperty("count")]
		public int Count { get; set; }

		[JsonProperty("items")]
		public IList<Item> Items { get; set; }
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

		[JsonProperty("url")]
		public string Url { get; set; }

		[JsonProperty("is_supporter")]
		public int IsSupporter { get; set; }

		[JsonProperty("bio")]
		public string Bio { get; set; }

		[JsonProperty("relationship")]
		public string Relationship { get; set; }

		[JsonProperty("user_avatar")]
		public string UserAvatar { get; set; }

		[JsonProperty("is_private")]
		public int IsPrivate { get; set; }

		[JsonProperty("contact")]
		[JsonConverter(typeof(SingleObjectArrayConverter<Contact>))]
		public object Contact { get; set; }
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

		[JsonProperty("beer_ibu")]
		public int BeerIbu { get; set; }

		[JsonProperty("beer_slug")]
		public string BeerSlug { get; set; }

		[JsonProperty("beer_description")]
		public string BeerDescription { get; set; }

		[JsonProperty("is_in_production")]
		public int IsInProduction { get; set; }

		[JsonProperty("beer_style_id")]
		public int BeerStyleId { get; set; }

		[JsonProperty("beer_style")]
		public string BeerStyle { get; set; }

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

		[JsonProperty("url")]
		public string Url { get; set; }
	}

	public class Location3
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
		[JsonConverter(typeof(SingleObjectArrayConverter<Contact3>))]
		public Contact3 Contact { get; set; }

		[JsonProperty("location")]
		public Location3 Location { get; set; }

		[JsonProperty("brewery_active")]
		public int BreweryActive { get; set; }
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

	public class Item3
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
		public IList<Item3> Items { get; set; }
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

	public class Item4
	{
		[JsonProperty("photo_id")]
		public int PhotoId { get; set; }

		[JsonProperty("photo")]
		public Photo2 Photo { get; set; }
	}

	public class Media2
	{
		[JsonProperty("count")]
		public int Count { get; set; }

		[JsonProperty("items")]
		public IList<Item4> Items { get; set; }
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

	public class Item5
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
		public IList<Item5> Items { get; set; }
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
		public Beer3 Beer { get; set; }

		[JsonProperty("brewery")]
		public Brewery3 Brewery { get; set; }

		[JsonProperty("venue")]
		public object Venue { get; set; }

		[JsonProperty("comments")]
		public Comments Comments { get; set; }

		[JsonProperty("toasts")]
		public Toasts Toasts { get; set; }

		[JsonProperty("media")]
		public Media2 Media { get; set; }

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

	public class Beer4
	{
		[JsonProperty("bid")]
		public int Bid { get; set; }

		[JsonProperty("beer_name")]
		public string BeerName { get; set; }

		[JsonProperty("beer_abv")]
		public double BeerAbv { get; set; }

		[JsonProperty("beer_ibu")]
		public int BeerIbu { get; set; }

		[JsonProperty("beer_style")]
		public string BeerStyle { get; set; }

		[JsonProperty("beer_label")]
		public string BeerLabel { get; set; }

		[JsonProperty("auth_rating")]
		public double AuthRating { get; set; }

		[JsonProperty("wish_list")]
		public bool WishList { get; set; }
	}

	public class Contact4
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

	public class Brewery4
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
		[JsonConverter(typeof(SingleObjectArrayConverter<Contact4>))]
		public Contact4 Contact { get; set; }

		[JsonProperty("location")]
		public Location4 Location { get; set; }

		[JsonProperty("brewery_active")]
		public int BreweryActive { get; set; }
	}

	public class Friends
	{
		[JsonProperty("items")]
		public IList<object> Items { get; set; }

		[JsonProperty("count")]
		public int Count { get; set; }
	}

	public class Item6
	{
		[JsonProperty("rating_score")]
		public double RatingScore { get; set; }

		[JsonProperty("beer")]
		public Beer4 Beer { get; set; }

		[JsonProperty("brewery")]
		public Brewery4 Brewery { get; set; }

		[JsonProperty("friends")]
		public Friends Friends { get; set; }
	}

	public class Similar
	{
		[JsonProperty("count")]
		public int Count { get; set; }

		[JsonProperty("items")]
		public IList<Item6> Items { get; set; }
	}

	public class Friends2
	{
		[JsonProperty("count")]
		public int Count { get; set; }

		[JsonProperty("items")]
		public IList<object> Items { get; set; }
	}

	public class Beer5
	{
		[JsonProperty("bid")]
		public int Bid { get; set; }

		[JsonProperty("beer_label")]
		public string BeerLabel { get; set; }

		[JsonProperty("beer_slug")]
		public string BeerSlug { get; set; }

		[JsonProperty("beer_name")]
		public string BeerName { get; set; }

		[JsonProperty("is_vintage")]
		public int IsVintage { get; set; }

		[JsonProperty("is_variant")]
		public int IsVariant { get; set; }
	}

	public class Item7
	{
		[JsonProperty("beer")]
		public Beer5 Beer { get; set; }
	}

	public class Vintages
	{
		[JsonProperty("count")]
		public int Count { get; set; }

		[JsonProperty("items")]
		public IList<Item7> Items { get; set; }
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

		[JsonProperty("beer_ibu")]
		public int BeerIbu { get; set; }

		[JsonProperty("beer_description")]
		public string BeerDescription { get; set; }

		[JsonProperty("beer_style")]
		public string BeerStyle { get; set; }

		[JsonProperty("is_in_production")]
		public int IsInProduction { get; set; }

		[JsonProperty("beer_slug")]
		public string BeerSlug { get; set; }

		[JsonProperty("is_homebrew")]
		public int IsHomebrew { get; set; }

		[JsonProperty("created_at")]
		public string CreatedAt { get; set; }

		[JsonProperty("rating_count")]
		public int RatingCount { get; set; }

		[JsonProperty("rating_score")]
		public double RatingScore { get; set; }

		[JsonProperty("stats")]
		public Stats Stats { get; set; }

		[JsonProperty("brewery")]
		public Brewery Brewery { get; set; }

		[JsonProperty("auth_rating")]
		public double AuthRating { get; set; }

		[JsonProperty("wish_list")]
		public bool WishList { get; set; }

		[JsonProperty("media")]
		public Media Media { get; set; }

		[JsonProperty("checkins")]
		[JsonConverter(typeof(SingleObjectArrayConverter<Checkins>))]
		public Checkins Checkins { get; set; }

		[JsonProperty("similar")]
		public Similar Similar { get; set; }

		[JsonProperty("friends")]
		public Friends2 Friends { get; set; }

		[JsonProperty("vintages")]
		public Vintages Vintages { get; set; }
	}

	public class Response
	{
		[JsonProperty("beer")]
		public Beer Beer { get; set; }
	}

	public class BeerInfo : BasicRequest, IAuthenticatedRequest, IUnAuthenticatedRequest
	{
		protected override string EndPointWithConfiguration { get { return "v4/beer/info{0}"; } }

		[JsonProperty("meta")]
		public Meta Meta { get; set; }

		[JsonProperty("notifications")]
		[JsonConverter(typeof(SingleObjectArrayConverter<Notifications>))]
		public Notifications Notifications { get; set; }

		[JsonProperty("response")]
		public Response Response { get; set; }
	}
}