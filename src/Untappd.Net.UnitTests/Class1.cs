using System;
using NUnit.Framework;
using Untappd.Net.Client;
using Untappd.Net.Request;
using UserInfo = Untappd.Net.Responses.UserInfo;
using ActivityFeed = Untappd.Net.Responses.Feeds.ActivityFeed;
using UserActivityFeed = Untappd.Net.Responses.Feeds.UserActivityFeed;

namespace Untappd.Net.UnitTests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        [Ignore]
        public void Test()
        {

            var ts = new UnAuthenticatedUntappdCredentials("id", "scrt");
            var t = new Repository().Get<UserInfo.UserInfo>(ts, "tparnell");
            Console.WriteLine(t);
        }

        [Test]
        [Ignore]
        public void GetActualJsonRequest()
        {
            var credentials = new AuthenticatedUntappdCredentials(
                "",
                "",
                "");

            var repo = new Repository();
            var activityFeed = repo.Get<UserActivityFeed.UserActivityFeed>(credentials);

        }
    }
}
