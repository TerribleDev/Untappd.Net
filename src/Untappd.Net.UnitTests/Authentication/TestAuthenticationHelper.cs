using System;
using NUnit.Framework;
using Untappd.Net.Authentication;
using Untappd.Net.OAuth;

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
			AuthenticationHelper.TokenUrl(new UnAuthenticatedUntappdCredentials("d", "d"), "ds", string.Empty);
		}

		[Test]
		public void TestTokenUrl()
		{
			var s = AuthenticationHelper.TokenUrl(new UnAuthenticatedUntappdCredentials("d", "d"), "ds", "code");
			Assert.AreEqual(s, Constants.OAuthTokenEndPoint + "/?client_id=d&client_secret=d&response_type=code&redirect_url=ds&code=code");
		}

		[Test]
		public void TestRedirectUrl()
		{
			var s = AuthenticationHelper.RedirectUserTo(new UnAuthenticatedUntappdCredentials("d", "d"), "ds");
			Assert.AreEqual(s, Constants.BaseRequestString + "/?client_id=d&response_type=code&redirect_url=ds");
		}
	}
}