using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Untappd.Net.Authentication;
using Untappd.Net.Client;

namespace Untappd.Net.UnitTests.Authentication
{
    [TestFixture]
    public class TestAuthenticationHelper
    {
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestRedirectUserToException1()
        {

            AuthenticationHelper.RedirectUserTo(null, "url");
        }
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestRedirectUserToException2()
        {

            AuthenticationHelper.RedirectUserTo(new UnAuthenticatedUntappdCredentials("d", "d"), string.Empty);
        }
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestTokenUrlException1()
        {

            AuthenticationHelper.TokenUrl(null, "some", "code");
        }
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestTokenUrlException2()
        {

            AuthenticationHelper.TokenUrl(new UnAuthenticatedUntappdCredentials("d", "d"), string.Empty, "code");
        }
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestTokenUrlException3()
        {

            AuthenticationHelper.TokenUrl(new UnAuthenticatedUntappdCredentials("d", "d"),  "ds", string.Empty);
        }
    }
}
