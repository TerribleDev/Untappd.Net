using System;
using NUnit.Framework;
using Untappd.Net.Client;

namespace Untappd.Net.UnitTests.Client
{
    [TestFixture]
    public class TestUnAuthenticatedUntappdCredentials
    {
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExpectClientIdException()
        {
            var t = new UnAuthenticatedUntappdCredentials(string.Empty, "t");
        }
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExpectClientSecretException()
        {
            var t = new UnAuthenticatedUntappdCredentials("t", string.Empty);
        }
    }
}
