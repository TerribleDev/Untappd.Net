using System;
using NUnit.Framework;
using Untappd.Net.Exception;
using Moq;
using RestSharp;


namespace Untappd.Net.UnitTests.Exception
{
    [TestFixture]
    public class TestHttpErrorException
    {
        [Test]
        public void ConfirmNullExceptions()
        {
            var mockRequest = new Mock<IRestRequest>();
            var mockResponse = new Mock<IRestResponse>();
           
            Assert.Throws<ArgumentNullException>(()=>{
                    var t = new HttpErrorException(mockRequest.Object, null);
                    Console.WriteLine(t);

                });
            Assert.Throws<ArgumentNullException>(()=>{
                    var t = new HttpErrorException(null, mockResponse.Object);
                    Console.WriteLine(t);

                });
        }
    }
}

