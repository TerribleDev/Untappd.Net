using System;
using NUnit.Framework;
using Untappd.Net.Responses.Actions;

namespace Untappd.Net.UnitTests.Responses.Actions
{
    [TestFixture]
    public class TestCheckInAction
    {
        [Test]
        public void TestAccessors()
        {
#pragma warning disable NR0026 // Possible unassigned object created by 'new'
            Assert.Throws<ArgumentNullException>(() => { new CheckIn(string.Empty, "timezone", 1); });
            Assert.Throws<ArgumentNullException>(() => { new CheckIn("1", string.Empty, 1); });
#pragma warning restore NR0026 // Possible unassigned object created by 'new'
            var checkin = new CheckIn("offset", "timezone", 1);
            Assert.IsNotNullOrEmpty(checkin.RequestMethod.ToString());
            Assert.Throws<ArgumentOutOfRangeException>(() => { checkin.Rating = -1; });
            Assert.Throws<ArgumentOutOfRangeException>(() => { checkin.Rating = 6; });
            Assert.Throws<ArgumentOutOfRangeException>(() => { checkin.Shout = new string('d', 141); });
            checkin.Rating = 3;
            Assert.AreEqual(3, checkin.Rating);
            const string t = "tst";
            checkin.Shout = t;
            Assert.IsNotNullOrEmpty(checkin.EndPoint);
            Assert.AreEqual(checkin.Shout, t);
        }

        [Test]
        public void TestDictionaryGeneration()
        {
            var checkin = new CheckIn("offset", "timezone", 1);
            Assert.AreEqual(checkin.BodyParameters["gmt_offset"], "offset");
            Assert.AreEqual(checkin.BodyParameters["timezone"], "timezone");
            Assert.AreEqual(checkin.BodyParameters["bid"], 1);

            Assert.IsFalse(checkin.BodyParameters.ContainsKey("geolat"));
            checkin.Geolat = 4;
            Assert.IsTrue(checkin.BodyParameters.ContainsKey("geolat"));
            Assert.AreEqual(checkin.BodyParameters["geolat"], 4);

            Assert.IsFalse(checkin.BodyParameters.ContainsKey("geolng"));
            checkin.Geolng = 4;
            Assert.IsTrue(checkin.BodyParameters.ContainsKey("geolng"));
            Assert.AreEqual(checkin.BodyParameters["geolng"], 4);

            Assert.IsFalse(checkin.BodyParameters.ContainsKey("shout"));
            checkin.Shout = "shout";
            Assert.IsTrue(checkin.BodyParameters.ContainsKey("shout"));
            Assert.AreEqual(checkin.BodyParameters["shout"], "shout");

            Assert.IsFalse(checkin.BodyParameters.ContainsKey("rating"));
            checkin.Rating = 2;
            Assert.IsTrue(checkin.BodyParameters.ContainsKey("rating"));
            Assert.AreEqual(checkin.BodyParameters["rating"], 2);



        }

    }
}
