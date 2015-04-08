# Untappd.Net

This is a c# wrapper around the Untappd API. This can be downloaded via [Nuget](https://www.nuget.org/packages/Untappd.Net/)

## Coverage

So far only the Requests that do not require user tokens have been implemented


## How do I use?

* Request an [API Key](http://untappd.com/api/register)
* You should be able to make a repository and call the get method with the thing you are requesting.

Note: Additional parameters can be passed into the Get Method with an IDictionary.

```csharp

var ts = new UnAuthenticatedUntappdCredentials("key", "secret");
var t = new Repository().Get<UserDistinctBeers>(ts, "tparnell");


```


## Contributing

* There are no special instructions, submit pull requests against the master branch.
* Releases to nuget occur on successful release branch builds
 * The only reason I do not publish on master, is because sometimes commits can just contain readme files, or unit tests changes that do not affect the nuget package

## TODO

* Actually Make unit tests
* Add authentication wrapper
* Implement API calls that require authentication tokens
* Coveralls?
* Code Quality?
