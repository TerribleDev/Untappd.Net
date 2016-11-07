using System;
using Moq;
using NUnit.Framework;
using RestSharp;
using Untappd.Net.Exception;

namespace Untappd.Net.UnitTests.Exception
{
	[TestFixture]
	public class TestHttpErrorException
	{
		[Test]
		public void ConfirmNullExceptions()
		{
			// var mockRequest = new Mock<IRestRequest>();
			// var mockResponse = new Mock<IRestResponse>();

			// Assert.Throws<ArgumentNullException>(() =>
			// {
			// 	var t = new HttpErrorException(mockRequest.Object, null);
			// 	Console.WriteLine(t);
			// });
			// Assert.Throws<ArgumentNullException>(() =>
			// {
			// 	var t = new HttpErrorException(null, mockResponse.Object);
			// 	Console.WriteLine(t);
			// });
		}
	}
}