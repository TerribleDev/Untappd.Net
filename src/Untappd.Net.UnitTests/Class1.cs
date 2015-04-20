using System;
using NUnit.Framework;
using Untappd.Net.Client;
using Untappd.Net.Request;
using Untappd.Net.Responses.UserDistinctBeer;
using Untappd.Net.Responses.UserInfo;

namespace Untappd.Net.UnitTests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        [Ignore]
        public void Test()
        {
            var ts = new UnAuthenticatedUntappdCredentials("id", "se");
            var t = new Repository().Get<UserInfo>(ts, "tparnell");
            Console.WriteLine(t);
        }
    }
}
