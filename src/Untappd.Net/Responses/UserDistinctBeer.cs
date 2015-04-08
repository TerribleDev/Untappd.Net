using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Untappd.Net.Request;

namespace Untappd.Net.Responses.UserDistinctBeer
{

    public class UserDistinctBeerRootobject : BaseRequest
    {
        public Beers beers { get; set; }
        protected override string _EndPoint { get { throw new NotImplementedException(); } }
    }

    public class Beers
    {
        public string sort { get; set; }
        public string sort_english { get; set; }
        public int count { get; set; }
        public Items items { get; set; }
    }

    public class Items
    {
        public int first_checkin_id { get; set; }
        public string first_created_at { get; set; }
        public int recent_checkin_id { get; set; }
        public string recent_created_at { get; set; }
        public string recent_created_at_timezone { get; set; }
        public float rating_score { get; set; }
        public string first_had { get; set; }
        public int count { get; set; }
        public Beer beer { get; set; }
        public Brewery brewery { get; set; }
    }

    public class Beer
    {
        public int bid { get; set; }
        public string beer_name { get; set; }
        public string beer_label { get; set; }
        public float beer_abv { get; set; }
        public int beer_ibu { get; set; }
        public string beer_slug { get; set; }
        public string beer_style { get; set; }
        public string beer_description { get; set; }
        public string created_at { get; set; }
        public float auth_rating { get; set; }
        public bool wish_list { get; set; }
        public float rating_score { get; set; }
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

}
