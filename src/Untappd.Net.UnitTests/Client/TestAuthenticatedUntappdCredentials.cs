using System;
using NUnit.Framework;
using Untappd.Net.Client;

namespace Untappd.Net.UnitTests.Client
{
    [TestFixture]
    public class TestAuthenticatedUntappdCredentials
    {
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExpectException()
        {
            var t = new AuthenticatedUntappdCredentials(null, "d", "d");
        }
        [Test]
        public void ExpectValid()
        {
            var token = "awesome";
            var t = new AuthenticatedUntappdCredentials(token, "d", "d");
            Assert.AreEqual(token, "awesome");
            token = "newString";
            //Make sure the reference is not copied over
            Assert.AreEqual("awesome", t.AccessToken);
        }
    }
}
