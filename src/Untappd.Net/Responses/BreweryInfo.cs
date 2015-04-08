using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Untappd.Net.Request;

namespace Untappd.Net.Responses.BreweryInfo
{

    public class BreweryInfoRootobject : BaseRequest
    {
        protected override string _EndPoint { get { return "v4/brewery/info/{0}"; } }
        public Brewery brewery { get; set; }
    }

    public class Brewery
    {
        public int brewery_id { get; set; }
        public string brewery_name { get; set; }
        public string brewery_slug { get; set; }
        public string brewery_label { get; set; }
        public string country_name { get; set; }
        public int brewery_in_production { get; set; }
        public int is_independent { get; set; }
        public Claimed_Status claimed_status { get; set; }
        public int beer_count { get; set; }
        public Contact contact { get; set; }
        public string brewery_type { get; set; }
        public int brewery_type_id { get; set; }
        public Location location { get; set; }
        public Rating rating { get; set; }
        public string brewery_description { get; set; }
        public Stats stats { get; set; }
        public Owners owners { get; set; }
        public Media media { get; set; }
        public Beer_List beer_list { get; set; }
    }

    public class Claimed_Status
    {
        public bool is_claimed { get; set; }
        public string claimed_slug { get; set; }
        public bool follow_status { get; set; }
        public int follower_count { get; set; }
        public int uid { get; set; }
        public string mute_status { get; set; }
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
        public string brewery_address { get; set; }
        public string brewery_city { get; set; }
        public string brewery_state { get; set; }
        public float brewery_lat { get; set; }
        public float brewery_lng { get; set; }
    }

    public class Rating
    {
        public int count { get; set; }
        public float rating_score { get; set; }
    }

    public class Stats
    {
        public int total_count { get; set; }
        public int unique_count { get; set; }
        public int monthly_count { get; set; }
        public int weekly_count { get; set; }
        public int user_count { get; set; }
        public float age_on_service { get; set; }
    }

    public class Owners
    {
        public int count { get; set; }
        public object[] items { get; set; }
    }

    public class Media
    {
        public int count { get; set; }
        public Items items { get; set; }
    }

    public class Items
    {
        public int photo_id { get; set; }
        public Photo photo { get; set; }
        public string created_at { get; set; }
        public int checkin_id { get; set; }
        public Beer beer { get; set; }
        public Brewery1 brewery { get; set; }
        public User user { get; set; }
        public object[] venue { get; set; }
    }

    public class Photo
    {
        public string photo_img_sm { get; set; }
        public string photo_img_md { get; set; }
        public string photo_img_lg { get; set; }
        public string photo_img_og { get; set; }
    }

    public class Beer
    {
        public int bid { get; set; }
        public string beer_name { get; set; }
        public float beer_abv { get; set; }
        public string beer_label { get; set; }
        public string beer_style { get; set; }
        public int auth_rating { get; set; }
        public bool wish_list { get; set; }
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
        public float lat { get; set; }
        public float lng { get; set; }
    }

    public class User
    {
        public int uid { get; set; }
        public string user_name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string user_avatar { get; set; }
        public string relationship { get; set; }
        public int is_private { get; set; }
    }

    public class Beer_List
    {
        public bool is_super { get; set; }
        public string sort { get; set; }
        public string filter { get; set; }
        public int count { get; set; }
        public Items1 items { get; set; }
        public int beer_count { get; set; }
    }

    public class Items1
    {
        public bool has_had { get; set; }
        public int total_count { get; set; }
        public Beer1 beer { get; set; }
        public Brewery2 brewery { get; set; }
        public object[] friends { get; set; }
    }

    public class Beer1
    {
        public int bid { get; set; }
        public string beer_name { get; set; }
        public string beer_label { get; set; }
        public string beer_style { get; set; }
        public float beer_abv { get; set; }
        public int beer_ibu { get; set; }
        public string beer_slug { get; set; }
        public string beer_description { get; set; }
        public int is_in_production { get; set; }
        public string created_at { get; set; }
        public int auth_rating { get; set; }
        public bool wish_list { get; set; }
        public float rating_score { get; set; }
        public int rating_count { get; set; }
    }

    public class Brewery2
    {
        public int brewery_id { get; set; }
        public string brewery_name { get; set; }
        public string brewery_slug { get; set; }
        public string brewery_label { get; set; }
        public string country_name { get; set; }
        public Contact2 contact { get; set; }
        public Location2 location { get; set; }
        public int brewery_active { get; set; }
    }

    public class Contact2
    {
        public string twitter { get; set; }
        public string facebook { get; set; }
        public string instagram { get; set; }
        public string url { get; set; }
    }

    public class Location2
    {
        public string brewery_city { get; set; }
        public string brewery_state { get; set; }
        public float lat { get; set; }
        public float lng { get; set; }
    }

}
