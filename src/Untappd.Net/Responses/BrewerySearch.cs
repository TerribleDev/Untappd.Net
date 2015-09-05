using System.Collections.Generic;
using Newtonsoft.Json;
using Untappd.Net.Request;

namespace Untappd.Net.Responses.BrewerySearch
{
	public class ResponseTime
	{
		[JsonProperty("time")]
		public double Time { get; set; }

		[JsonProperty("measure")]
		public string Measure { get; set; }
	}

	public class InitTime
	{
		[JsonProperty("time")]
		public double Time { get; set; }

		[JsonProperty("measure")]
		public string Measure { get; set; }
	}

	public class Meta
	{
		[JsonProperty("code")]
		public int Code { get; set; }

		[JsonProperty("response_time")]
		public ResponseTime ResponseTime { get; set; }

		[JsonProperty("init_time")]
		public InitTime InitTime { get; set; }
	}

	public class UnreadCount
	{
		[JsonProperty("comments")]
		public int Comments { get; set; }

		[JsonProperty("toasts")]
		public int Toasts { get; set; }

		[JsonProperty("friends")]
		public int Friends { get; set; }

		[JsonProperty("messages")]
		public int Messages { get; set; }

		[JsonProperty("news")]
		public int News { get; set; }
	}

	public class Notifications
	{
		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("unread_count")]
		public UnreadCount UnreadCount { get; set; }
	}

	public class Location
	{
		[JsonProperty("brewery_city")]
		public string BreweryCity { get; set; }

		[JsonProperty("brewery_state")]
		public string BreweryState { get; set; }

		[JsonProperty("lat")]
		public int Lat { get; set; }

		[JsonProperty("lng")]
		public int Lng { get; set; }
	}

	public class Brewery2
	{
		[JsonProperty("brewery_id")]
		public int BreweryId { get; set; }

		[JsonProperty("beer_count")]
		public int BeerCount { get; set; }

		[JsonProperty("brewery_name")]
		public string BreweryName { get; set; }

		[JsonProperty("brewery_label")]
		public string BreweryLabel { get; set; }

		[JsonProperty("country_name")]
		public string CountryName { get; set; }

		[JsonProperty("location")]
		public Location Location { get; set; }
	}

	public class Item
	{
		[JsonProperty("brewery")]
		public Brewery2 Brewery { get; set; }
	}

	public class Brewery
	{
		[JsonProperty("count")]
		public int Count { get; set; }

		[JsonProperty("items")]
		public IList<Item> Items { get; set; }
	}

	public class Response
	{
		[JsonProperty("search_type")]
		public string SearchType { get; set; }

		[JsonProperty("sort")]
		public string Sort { get; set; }

		[JsonProperty("term")]
		public string Term { get; set; }

		[JsonProperty("key")]
		public string Key { get; set; }

		[JsonProperty("found")]
		public int Found { get; set; }

		[JsonProperty("brewery")]
		public Brewery Brewery { get; set; }
	}

	public class BrewerySearch : BasicRequest, IAuthenticatedRequest, IUnAuthenticatedRequest
	{
		protected override string EndPointWithConfiguration { get { return "v4/search/brewery"; } }

		[JsonProperty("meta")]
		public Meta Meta { get; set; }

		[JsonProperty("notifications")]
		[JsonConverter(typeof(SingleObjectArrayConverter<Notifications>))]
		public Notifications Notifications { get; set; }

		[JsonProperty("response")]
		public Response Response { get; set; }
	}
}