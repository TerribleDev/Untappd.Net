using NUnit.Framework;
using Untappd.Net.Exception;

namespace Untappd.Net.UnitTests.Exception
{
    [TestFixture]
    public class TestEndpointConfigurationException
    {
        [Test]
        [ExpectedException(typeof(EndpointConfigurationException), ExpectedMessage = "Invalid endpoint configured")]
        public void TestThrownExeption()
        {
            throw new EndpointConfigurationException();
        }

    }
}
