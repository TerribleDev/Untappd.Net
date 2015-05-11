using System.Collections.Generic;
using Newtonsoft.Json;
using Untappd.Net.Request;

namespace Untappd.Net.Responses.UserDistinctBeer
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

        [JsonProperty("beer_slug")]
        public string BeerSlug { get; set; }

        [JsonProperty("beer_style")]
        public string BeerStyle { get; set; }

        [JsonProperty("beer_description")]
        public string BeerDescription { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("auth_rating")]
        public double AuthRating { get; set; }

        [JsonProperty("wish_list")]
        public bool WishList { get; set; }

        [JsonProperty("rating_score")]
        public double RatingScore { get; set; }

        [JsonProperty("rating_count")]
        public int RatingCount { get; set; }
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

        [JsonProperty("first_checkin_id")]
        public int FirstCheckinId { get; set; }

        [JsonProperty("first_created_at")]
        public string FirstCreatedAt { get; set; }

        [JsonProperty("recent_checkin_id")]
        public int RecentCheckinId { get; set; }

        [JsonProperty("recent_created_at")]
        public string RecentCreatedAt { get; set; }

        [JsonProperty("recent_created_at_timezone")]
        public string RecentCreatedAtTimezone { get; set; }

        [JsonProperty("rating_score")]
        public double RatingScore { get; set; }

        [JsonProperty("first_had")]
        public string FirstHad { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("beer")]
        public Beer Beer { get; set; }

        [JsonProperty("brewery")]
        public Brewery Brewery { get; set; }
    }

    public class Beers
    {

        [JsonProperty("sort")]
        public string Sort { get; set; }

        [JsonProperty("sort_english")]
        public string SortEnglish { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("items")]
        public IList<Item> Items { get; set; }
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
        public int news { get; set; }
    }

    public class Notifications
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("unread_count")]
        public UnreadCount UnreadCount { get; set; }
    }

    public class Response
    {

        [JsonProperty("is_search")]
        public bool IsSearch { get; set; }

        [JsonProperty("beers")]
        public Beers Beers { get; set; }
    }

    public class UserDistinctBeers : BasicRequest, IAuthenticatedRequest, IUnAuthenticatedRequest
    {
        protected override string _EndPoint { get { return "v4/user/beers{0}"; } }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("notifications")]
        [JsonConverter(typeof(SingleObjectArrayConverter<Notifications>))]
        public Notifications Notifications { get; set; }

        [JsonProperty("response")]
        public Response Response { get; set; }
    }

}
