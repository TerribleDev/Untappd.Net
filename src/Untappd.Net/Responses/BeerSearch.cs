using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Untappd.Net.Request;

namespace Untappd.Net.Responses.BeerSearch
{

    public class BeerSearchRootobject : BaseRequest
    {
        protected override string _EndPoint { get { return "v4/beer/info/{0}"; } }
        public int found { get; set; }
        public string term { get; set; }
        public Beers beers { get; set; }
        public Homebrew homebrew { get; set; }
        public Breweries breweries { get; set; }
    }

    public class Beers
    {
        public int count { get; set; }
        public Items items { get; set; }
    }

    public class Items
    {
        public int checkin_count { get; set; }
        public bool have_had { get; set; }
        public int your_count { get; set; }
        public Beer beer { get; set; }
        public Brewery brewery { get; set; }
    }

    public class Beer
    {
        public int bid { get; set; }
        public string beer_name { get; set; }
        public string beer_label { get; set; }
        public int beer_abv { get; set; }
        public int beer_ibu { get; set; }
        public string beer_description { get; set; }
        public string created_at { get; set; }
        public string beer_style { get; set; }
        public int auth_rating { get; set; }
        public bool wish_list { get; set; }
        public int in_production { get; set; }
    }

    public class Brewery
    {
        public int brewery_id { get; set; }
        public string brewery_name { get; set; }
        public string brewery_slug { get; set; }
        public string brewery_label { get; set; }
        public string country_name { get; set; }
        public Contact contact { get; set; }
        public Location location { get; set; }
        public int brewery_active { get; set; }
    }

    public class Contact
    {
        public string twitter { get; set; }
        public string facebook { get; set; }
        public string instagram { get; set; }
        public string url { get; set; }
    }

    public class Location
    {
        public string brewery_city { get; set; }
        public string brewery_state { get; set; }
        public float lat { get; set; }
        public float lng { get; set; }
    }

    public class Homebrew
    {
        public int count { get; set; }
        public Items1 items { get; set; }
    }

    public class Items1
    {
        public int checkin_count { get; set; }
        public bool have_had { get; set; }
        public int your_count { get; set; }
        public Beer1 beer { get; set; }
        public Brewery1 brewery { get; set; }
    }

    public class Beer1
    {
        public int bid { get; set; }
        public string beer_name { get; set; }
        public string beer_label { get; set; }
        public int beer_abv { get; set; }
        public int beer_ibu { get; set; }
        public string beer_description { get; set; }
        public string created_at { get; set; }
        public string beer_style { get; set; }
        public int auth_rating { get; set; }
        public bool wish_list { get; set; }
        public int in_production { get; set; }
    }

    public class Brewery1
    {
        public int brewery_id { get; set; }
        public string brewery_name { get; set; }
        public string brewery_slug { get; set; }
        public string brewery_label { get; set; }
        public string country_name { get; set; }
        public Contact1 contact { get; set; }
        public Location1 location { get; set; }
        public int brewery_active { get; set; }
    }

    public class Contact1
    {
        public string twitter { get; set; }
        public string facebook { get; set; }
        public string instagram { get; set; }
        public string url { get; set; }
    }

    public class Location1
    {
        public string brewery_city { get; set; }
        public string brewery_state { get; set; }
        public int lat { get; set; }
        public int lng { get; set; }
    }

    public class Breweries
    {
        public int count { get; set; }
        public Items2 items { get; set; }
    }

    public class Items2
    {
        public Brewery2 brewery { get; set; }
    }

    public class Brewery2
    {
        public int brewery_id { get; set; }
        public int beer_count { get; set; }
        public string brewery_name { get; set; }
        public string brewery_label { get; set; }
        public string country_name { get; set; }
        public Location2 location { get; set; }
    }

    public class Location2
    {
        public string brewery_city { get; set; }
        public string brewery_state { get; set; }
        public int lat { get; set; }
        public int lng { get; set; }
    }

}
