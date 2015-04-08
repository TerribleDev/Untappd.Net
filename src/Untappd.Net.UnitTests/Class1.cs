using System;
using NUnit.Framework;
using Untappd.Client.Net;
using Untappd.Net.Request;
using Untappd.Net.Responses.UserDistinctBeer;

namespace Untappd.Net.UnitTests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        [Ignore]
        public void Test()
        {
            var ts = new UnAuthenticatedUntappdCredentials("clientid", "clientkey");
            var t = new Repository().Get<UserDistinctBeers>(ts, "tparnell");
            Console.WriteLine(t);
        }
    }
}
