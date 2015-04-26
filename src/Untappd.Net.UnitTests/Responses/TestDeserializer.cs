using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using NUnit.Framework;
using Untappd.Net.Client;
using Untappd.Net.Request;
using Untappd.Net.Responses.BeerInfo;
using Untappd.Net.Responses.BeerSearch;
using Untappd.Net.Responses.BreweryInfo;
using Untappd.Net.Responses.BrewerySearch;
using Untappd.Net.Responses.Feeds.ActivityFeed;
using Untappd.Net.Responses.Feeds.UserActivityFeed;
using Untappd.Net.Responses.UserBadges;
using Untappd.Net.Responses.UserFriends;
using Untappd.Net.Responses.UserInfo;
using Untappd.Net.Responses.VenueInfo;
using UserDistinctBeers = Untappd.Net.Responses.UserDistinctBeer;
using UserWishList = Untappd.Net.Responses.UserWishlist;
using System;

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
            var credentials = new AuthenticatedUntappdCredentials("");

            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("q", "wild rose");

            var repo = new Repository();
            //var resp = repo.Get<ActivityFeed.ActivityFeed>(credentials);
            var resp3 = repo.Get<BrewerySearch>(credentials, "", parameters);
            var resp2 = repo.Get<UserActivityFeed>(credentials);
        }

        [Test]
        public void TestJsonDeserializeUserBadges()
        {
            var json = File.ReadAllText(string.Format(ResponsePath, "UserBadges.json"));
            var jsonresult = JsonConvert.DeserializeObject<UserBadges>(json);
        }

        [Test]
        public void TestJsonDeserializerBeerInfo()
        {
            var json = File.ReadAllText(string.Format(ResponsePath, "BeerInfo.json"));
            var jsonresult = JsonConvert.DeserializeObject<BeerInfo>(json);
        }

        [Test]
        public void TestJsonDeserializerBeerSearch()
        {
            var json = File.ReadAllText(string.Format(ResponsePath, "BeerSearch.json"));
            var jsonresult = JsonConvert.DeserializeObject<BeerSearch>(json);
        }

        [Test]
        public void TestJsonDeserializerBreweryInfo()
        {
            var json = File.ReadAllText(string.Format(ResponsePath, "BreweryInfo.json"));
            var jsonresult = JsonConvert.DeserializeObject<BreweryInfo>(json);
        }

        [Test]
        public void TestJsonDeserializerBrewerySearch()
        {
            var json = File.ReadAllText(string.Format(ResponsePath, "BrewerySearch.json"));
            var jsonresult = JsonConvert.DeserializeObject<BrewerySearch>(json);
        }

        [Test]
        public void TestJsonDeserializerUserDistinctBeers()
        {
            var json = File.ReadAllText(string.Format(ResponsePath, "UserDistinctBeers.json"));
            var jsonresult = JsonConvert.DeserializeObject<UserDistinctBeers.UserDistinctBeers>(json);
        }

        [Test]
        public void TestJsonDeserializerUserFriends()
        {
            var json = File.ReadAllText(string.Format(ResponsePath, "UserFriends.json"));
            var jsonresult = JsonConvert.DeserializeObject<UserFriends>(json);
        }

        [Test]
        public void TestJsonDeserializerUserInfo()
        {
            var json = File.ReadAllText(string.Format(ResponsePath, "UserInfo.json"));
            var jsonresult = JsonConvert.DeserializeObject<UserInfo>(json);
        }

        [Test]
        public void TestJsonDeserializerUserWishList()
        {
            var json = File.ReadAllText(string.Format(ResponsePath, "UserWishList.json"));
            var jsonresult = JsonConvert.DeserializeObject<UserWishList.UserWishList>(json);
        }

        [Test]
        public void TestJsonDeserializerVenueInfo()
        {
            var json = File.ReadAllText(string.Format(ResponsePath, "VenueInfo.json"));
            var jsonresult = JsonConvert.DeserializeObject<VenueInfo>(json);
        }

        [Test]
        public void TestJsonDeserializerActivityFeed()
        {
            var json = File.ReadAllText(string.Format(ResponsePath, "ActivityFeed.json"));
            var jsonresult = JsonConvert.DeserializeObject<ActivityFeed>(json);
        }

        [Test]
        public void TestJsonDeserializerUserActivityFeed()
        {
            var json = File.ReadAllText(string.Format(ResponsePath, "UserActivityFeed.json"));
            var jsonresult = JsonConvert.DeserializeObject<UserActivityFeed>(json);
        }

        [Test]
        [ExpectedException(typeof(NotImplementedException))]
        public void testNotImplementedException()
        {
             new SingleObjectArrayConverter<UserActivityFeed>().WriteJson(null, null, null);
        }

        [Test]
        public void testTypeValid()
        {
           Assert.IsTrue(new SingleObjectArrayConverter<UserActivityFeed>().CanConvert(typeof(UserActivityFeed)));
        }
    }
}
