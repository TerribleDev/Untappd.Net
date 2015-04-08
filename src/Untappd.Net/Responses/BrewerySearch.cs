using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Untappd.Net.Request;

namespace Untappd.Net.Responses.BrewerySearch
{

    public class BrewerySearchRootobject : BaseRequest
    {
        public int found { get; set; }
        public Brewery brewery { get; set; }
        protected override string _EndPoint { get { return "v4/search/beer/{0}"; } }
    }

    public class Brewery
    {
        public int count { get; set; }
        public Items items { get; set; }
    }

    public class Items
    {
        public Brewery1 brewery { get; set; }
    }

    public class Brewery1
    {
        public int brewery_id { get; set; }
        public int beer_count { get; set; }
        public string brewery_name { get; set; }
        public string brewery_label { get; set; }
        public string country_name { get; set; }
        public Location location { get; set; }
    }

    public class Location
    {
        public string brewery_city { get; set; }
        public string brewery_state { get; set; }
        public int lat { get; set; }
        public int lng { get; set; }
    }

}
