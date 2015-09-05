using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using RestSharp;
using Untappd.Net.Authentication;
using Untappd.Net.Exception;
using Untappd.Net.Request;
using Untappd.Net.Responses.Actions;
using Untappd.Net.Responses.BeerInfo;

namespace Untappd.Net.UnitTests.Request
{
	[TestFixture]
	public class TestRepository
	{
		[Test]
		public void ConfirmRequestWorks()
		{
			var mockCreds = new Mock<IUnAuthenticatedUntappdCredentials>();
			mockCreds.Setup(a => a.AuthenticationData).Returns(new ReadOnlyDictionary<string, string>(new Dictionary<string, string>()
			{
				{"client_id", "id"},
				 {"client_secret", "secret"}
			}));
			var bodyParam = new Dictionary<string, object> { { "key", "value" } };
			var client = new Mock<IRestClient>();
			var request = new Mock<IRestRequest>();
			request.Setup(a => a.AddParameter(It.IsAny<string>(), It.IsAny<string>()));
			request.Setup(a => a.AddParameter(It.IsAny<string>(), It.IsAny<string>()));

			var response = new Mock<IRestResponse>();
			response.Setup(a => a.Content).Returns(File.ReadAllText("../../Responses/Json/BeerInfo.json"));
			client.Setup(a => a.Execute(It.IsAny<IRestRequest>())).Callback(() =>
			{
			}).Returns(response.Object);
			client.Setup(a => a.ExecuteTaskAsync(It.IsAny<IRestRequest>())).Callback(() =>
			{
			}).Returns(Task.Run(() => response.Object));
			var repository = new Repository(client.Object, request.Object);

			repository.Get<BeerInfo>(mockCreds.Object, "awesome", bodyParam);
			request.Verify(a => a.AddParameter("client_id", mockCreds.Object.AuthenticationData["client_id"]));
			request.Verify(a => a.AddParameter("client_secret", mockCreds.Object.AuthenticationData["client_secret"]));
			request.Verify(a => a.AddParameter("key", "value"));
			repository.GetAsync<BeerInfo>(mockCreds.Object, "awesome", bodyParam).Wait();
			request.Verify(a => a.AddParameter("client_id", mockCreds.Object.AuthenticationData["client_id"]));
			request.Verify(a => a.AddParameter("client_secret", mockCreds.Object.AuthenticationData["client_secret"]));
			request.Verify(a => a.AddParameter("key", "value"));

			var mockAuthCreds = new Mock<IAuthenticatedUntappdCredentials>();
			mockAuthCreds.Setup(a => a.AuthenticationData).Returns(new ReadOnlyDictionary<string, string>(new Dictionary<string, string>()
			{
				{"access_token", "accessToken"}
			}));

			repository.Get<BeerInfo>(mockAuthCreds.Object, "awesome", bodyParam);
			request.Verify(a => a.AddParameter("key", "value"));
			request.Verify(a => a.AddParameter("access_token", "accessToken"));
			repository.GetAsync<BeerInfo>(mockAuthCreds.Object, "awesome", bodyParam).Wait();
			request.Verify(a => a.AddParameter("key", "value"));
			request.Verify(a => a.AddParameter("access_token", "accessToken"));

			mockAuthCreds.Setup(a => a.AuthenticationData).Returns(new ReadOnlyDictionary<string, string>(new Dictionary<string, string>()
			{
				{"access_token", "PostaccessToken"}
			}));
			var checkin = new CheckIn("-5", "EST", 1044097) { Shout = "Awesome Brew", Rating = 4 };
			repository.FailFast = true;
			repository.OnExceptionThrown += (sender, e) =>
				{
					Assert.IsNotNull(sender);
					Assert.IsNotNull(e);
				};
			Assert.Throws<HttpErrorException>(() => repository.Post(mockAuthCreds.Object, checkin));
			repository.FailFast = false;
			repository.Post(mockAuthCreds.Object, checkin);
			request.Verify(a => a.AddParameter("access_token", "PostaccessToken"));

			mockAuthCreds.Setup(a => a.AuthenticationData).Returns(new ReadOnlyDictionary<string, string>(new Dictionary<string, string>()
			{
				{"access_token", "PostAsyncaccessToken"}
			}));
			repository.PostAsync(mockAuthCreds.Object, checkin).Wait();
			request.Verify(a => a.AddParameter("access_token", "PostAsyncaccessToken"));
		}

		[Test]
		public void ConfirmBasicConstructorWorks()
		{
			var constructorTest = new Repository();
			Assert.IsTrue(constructorTest.Client != null);
			Assert.IsTrue(constructorTest.Request != null);
		}

		[Test]
		public void ConfirmConfigureGetRequestClearsParams()
		{
			var constructorTest = new Repository();
			constructorTest.Request.Parameters.Add(new Parameter { Name = "param" });
			Assert.IsTrue(constructorTest.Request.Parameters.Count > 0);
			constructorTest.ConfigureRequest("endpoint");
			Assert.IsTrue(constructorTest.Request.Parameters.Count == 0);
		}
	}
}