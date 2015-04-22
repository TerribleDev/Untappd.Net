using System;
using System.Collections.Generic;
using NUnit.Framework;
using Untappd.Net.Client;
using Untappd.Net.Request;
using Newtonsoft.Json;
using UserInfo = Untappd.Net.Responses.UserInfo;
using ActivityFeed = Untappd.Net.Responses.Feeds.ActivityFeed;
using UserActivityFeed = Untappd.Net.Responses.Feeds.UserActivityFeed;
using UserBadges = Untappd.Net.Responses.UserBadges;
using BeerInfo = Untappd.Net.Responses.BeerInfo;
using BeerSearch = Untappd.Net.Responses.BeerSearch;
using BreweryInfo = Untappd.Net.Responses.BreweryInfo;
using BrewerySearch = Untappd.Net.Responses.BrewerySearch;
using UserDistinctBeers = Untappd.Net.Responses.UserDistinctBeer;
using UserFriends = Untappd.Net.Responses.UserFriends;
using UserWishList = Untappd.Net.Responses.UserWishlist;
using VenueInfo = Untappd.Net.Responses.VenueInfo;

namespace Untappd.Net.UnitTests
{
    [TestFixture]
    public class TestDeserializer
    {
        private static string ResponsePath = "../../Responses/Json/{0}";

        [Test]
        [Ignore]
        public void GetActualJsonRequest()
        {
            var credentials = new AuthenticatedUntappdCredentials(
                "",
                "",
                "");

            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("q", "wild rose");

            var repo = new Repository();
            //var resp = repo.Get<ActivityFeed.ActivityFeed>(credentials);
            var resp3 = repo.Get<BrewerySearch.BrewerySearch>(credentials, "", parameters);
            var resp2 = repo.Get<UserActivityFeed.UserActivityFeed>(credentials);
        }

        [Test]
        public void TestJsonDeserializeUserBadges()
        {
            var json = System.IO.File.ReadAllText(string.Format(ResponsePath, "UserBadges.json"));
            var jsonresult = JsonConvert.DeserializeObject<UserBadges.UserBadges>(json);
        }

        [Test]
        public void TestJsonDeserializerBeerInfo()
        {
            var json = System.IO.File.ReadAllText(string.Format(ResponsePath, "BeerInfo.json"));
            var jsonresult = JsonConvert.DeserializeObject<BeerInfo.BeerInfo>(json);
        }

        [Test]
        public void TestJsonDeserializerBeerSearch()
        {
            var json = System.IO.File.ReadAllText(string.Format(ResponsePath, "BeerSearch.json"));
            var jsonresult = JsonConvert.DeserializeObject<BeerSearch.BeerSearch>(json);
        }

        [Test]
        public void TestJsonDeserializerBreweryInfo()
        {
            var json = System.IO.File.ReadAllText(string.Format(ResponsePath, "BreweryInfo.json"));
            var jsonresult = JsonConvert.DeserializeObject<BreweryInfo.BreweryInfo>(json);
        }

        [Test]
        public void TestJsonDeserializerBrewerySearch()
        {
            var json = System.IO.File.ReadAllText(string.Format(ResponsePath, "BrewerySearch.json"));
            var jsonresult = JsonConvert.DeserializeObject<BrewerySearch.BrewerySearch>(json);
        }

        [Test]
        public void TestJsonDeserializerUserDistinctBeers()
        {
            var json = System.IO.File.ReadAllText(string.Format(ResponsePath, "UserDistinctBeers.json"));
            var jsonresult = JsonConvert.DeserializeObject<UserDistinctBeers.UserDistinctBeers>(json);
        }

        [Test]
        public void TestJsonDeserializerUserFriends()
        {
            var json = System.IO.File.ReadAllText(string.Format(ResponsePath, "UserFriends.json"));
            var jsonresult = JsonConvert.DeserializeObject<UserFriends.UserFriends>(json);
        }

        [Test]
        public void TestJsonDeserializerUserInfo()
        {
            var json = System.IO.File.ReadAllText(string.Format(ResponsePath, "UserInfo.json"));
            var jsonresult = JsonConvert.DeserializeObject<UserInfo.UserInfo>(json);
        }

        [Test]
        public void TestJsonDeserializerUserWishList()
        {
            var json = System.IO.File.ReadAllText(string.Format(ResponsePath, "UserWishList.json"));
            var jsonresult = JsonConvert.DeserializeObject<UserWishList.UserWishList>(json);
        }

        [Test]
        public void TestJsonDeserializerVenueInfo()
        {
            var json = System.IO.File.ReadAllText(string.Format(ResponsePath, "VenueInfo.json"));
            var jsonresult = JsonConvert.DeserializeObject<VenueInfo.VenueInfo>(json);
        }

        [Test]
        public void TestJsonDeserializerActivityFeed()
        {
            var json = System.IO.File.ReadAllText(string.Format(ResponsePath, "ActivityFeed.json"));
            var jsonresult = JsonConvert.DeserializeObject<ActivityFeed.ActivityFeed>(json);
        }

        [Test]
        public void TestJsonDeserializerUserActivityFeed()
        {
            var json = System.IO.File.ReadAllText(string.Format(ResponsePath, "UserActivityFeed.json"));
            var jsonresult = JsonConvert.DeserializeObject<UserActivityFeed.UserActivityFeed>(json);
        }
    }
}
