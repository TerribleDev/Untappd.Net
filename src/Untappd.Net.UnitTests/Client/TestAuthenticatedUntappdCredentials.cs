using System;
using NUnit.Framework;
using Untappd.Net.Authentication;

namespace Untappd.Net.UnitTests.Client
{
    [TestFixture]
    public class TestAuthenticatedUntappdCredentials
    {
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExpectException()
        {
            var t = new AuthenticatedUntappdCredentials(null);
        }
        [Test]
        public void ExpectValid()
        {
            var token = "awesome";
            var t = new AuthenticatedUntappdCredentials(token);
            Assert.AreEqual(token, "awesome");
            token = "newString";
            //Make sure the reference is not copied over
            Assert.AreEqual("awesome", t.AuthenticationData["access_token"]);
        }
    }
}
