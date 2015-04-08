using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Untappd.Net.Request;

namespace Untappd.Net.Responses.BeerSearch
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

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("beer_style")]
        public string BeerStyle { get; set; }

        [JsonProperty("auth_rating")]
        public int AuthRating { get; set; }

        [JsonProperty("wish_list")]
        public bool WishList { get; set; }

        [JsonProperty("in_production")]
        public int InProduction { get; set; }
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

        [JsonProperty("checkin_count")]
        public int CheckinCount { get; set; }

        [JsonProperty("have_had")]
        public bool HaveHad { get; set; }

        [JsonProperty("your_count")]
        public int YourCount { get; set; }

        [JsonProperty("beer")]
        public Beer Beer { get; set; }

        [JsonProperty("brewery")]
        public Brewery Brewery { get; set; }
    }

    public class Beers
    {

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("items")]
        public IList<Item> Items { get; set; }
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

        [JsonProperty("beer_description")]
        public string BeerDescription { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("beer_style")]
        public string BeerStyle { get; set; }

        [JsonProperty("auth_rating")]
        public int AuthRating { get; set; }

        [JsonProperty("wish_list")]
        public bool WishList { get; set; }

        [JsonProperty("in_production")]
        public int InProduction { get; set; }
    }

    public class Contact2
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
        public int Lat { get; set; }

        [JsonProperty("lng")]
        public int Lng { get; set; }
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
        public Contact2 Contact { get; set; }

        [JsonProperty("location")]
        public Location2 Location { get; set; }

        [JsonProperty("brewery_active")]
        public int BreweryActive { get; set; }
    }

    public class Item2
    {

        [JsonProperty("checkin_count")]
        public int CheckinCount { get; set; }

        [JsonProperty("have_had")]
        public bool HaveHad { get; set; }

        [JsonProperty("your_count")]
        public int YourCount { get; set; }

        [JsonProperty("beer")]
        public Beer2 Beer { get; set; }

        [JsonProperty("brewery")]
        public Brewery2 Brewery { get; set; }
    }

    public class Homebrew
    {

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("items")]
        public IList<Item2> Items { get; set; }
    }

    public class Location3
    {

        [JsonProperty("brewery_city")]
        public string BreweryCity { get; set; }

        [JsonProperty("brewery_state")]
        public string BreweryState { get; set; }

        [JsonProperty("lat")]
        public int Lat { get; set; }

        [JsonProperty("lng")]
        public int Lng { get; set; }
    }

    public class Brewery3
    {

        [JsonProperty("brewery_id")]
        public int BreweryId { get; set; }

        [JsonProperty("beer_count")]
        public int BeerCount { get; set; }

        [JsonProperty("brewery_name")]
        public string BreweryName { get; set; }

        [JsonProperty("brewery_label")]
        public string BreweryLabel { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("location")]
        public Location3 Location { get; set; }
    }

    public class Item3
    {

        [JsonProperty("brewery")]
        public Brewery3 Brewery { get; set; }
    }

    public class Breweries
    {

        [JsonProperty("items")]
        public IList<Item3> Items { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class Response
    {

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("brewery_id")]
        public bool BreweryId { get; set; }

        [JsonProperty("search_type")]
        public string SearchType { get; set; }

        [JsonProperty("type_id")]
        public int TypeId { get; set; }

        [JsonProperty("search_version")]
        public int SearchVersion { get; set; }

        [JsonProperty("found")]
        public int Found { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("term")]
        public string Term { get; set; }

        [JsonProperty("parsed_term")]
        public string ParsedTerm { get; set; }

        [JsonProperty("beers")]
        public Beers Beers { get; set; }

        [JsonProperty("homebrew")]
        public Homebrew Homebrew { get; set; }

        [JsonProperty("breweries")]
        public Breweries Breweries { get; set; }
    }

    public class BeerSearch : UnAuthenticatedRequest
    {

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("notifications")]
        public IList<object> Notifications { get; set; }

        [JsonProperty("response")]
        public Response Response { get; set; }

        protected override string _EndPoint
        {
            get { return "v4/search/beer"; }
        }
    }

}
