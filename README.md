**Master (Windows):** [![Build status](https://ci.appveyor.com/api/projects/status/e21297waldfrso3p/branch/master?svg=true)](https://ci.appveyor.com/project/tparnell8/untappd-net/branch/master)
**Master (Linux):** [![Build status](https://travis-ci.org/tparnell8/Untappd.Net.svg?branch=master)
**Release:**[![Build status](https://ci.appveyor.com/api/projects/status/e21297waldfrso3p/branch/Release?svg=true)](https://ci.appveyor.com/project/tparnell8/untappd-net/branch/Release)
**Code Coverage:** [![Coverage Status](https://coveralls.io/repos/tparnell8/Untappd.Net/badge.svg?branch=master)](https://coveralls.io/r/tparnell8/Untappd.Net?branch=master)

**Kanban** [![Stories in Ready](https://badge.waffle.io/tparnell8/untappd.net.png?label=ready&title=Ready)](https://waffle.io/tparnell8/untappd.net)

**Tips:** [![Shameless tip badge tips](https://img.shields.io/gratipay/TommyParnell.svg)](https://gratipay.com/TommyParnell)
**Chat:** [![Join the chat at https://gitter.im/tparnell8/Untappd.Net](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/tparnell8/Untappd.Net?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
# Untappd.Net

This is a c# wrapper around the Untappd API. This can be downloaded via [Nuget](https://www.nuget.org/packages/Untappd.Net/), or the [backup feed](https://www.myget.org/F/untappd-net/api/v2).

## API Coverage

Current both Authenticated and Unauthenticated requests.

More info: https://untappd.com/api/docs

For Authenticated requests, you should already have a valid token, provided via OAuth authentication.

Such authentication can be achieved using Owin OAuth Providers for ASP.NET Web Applications, which already have an Untappd provider.

More info: https://github.com/RockstarLabs/OwinOAuthProviders

## How do I use?

* Request an [API Key](https://untappd.com/api/register?register=new)
* You should be able to make a repository and call the get method with the thing you are requesting.

Note: Additional parameters can be passed into the Get Method with an IDictionary.

```csharp

var ts = new UnAuthenticatedUntappdCredentials("key", "secret");
var t = new Repository().Get<UserDistinctBeers>(ts, "tparnell");
var t = new Repository().Get<BeerInfo>(ts, "BeerIdHere");

```

For Authenticated requests:

```csharp

var ts = new AuthenticatedUntappdCredentials("token", "key", "secret");
var t = new Repository().Get<ActivityFeed>(ts);

```

For Actions (usually post requests). Note: Actions return a dynamic object. Usually these responses are not needed, and you should still be able to use the dynamic object's data. If strong typed returns is required feel free to file an issue. However we don't predict people will really need to care about the returns of these actions.


```csharp

var ts = new AuthenticatedUntappdCredentials("token", "key", "secret");
var checkin = new CheckIn("-5", "EST", 1044097) { Shout = "Awesome Brew", Rating = 4 };
var response = repository.Post(ts, checkin);

```

## Contributing

* Everyone is welcome to contribute!
* If you are looking for something to do, look at the issues.
* There are no special instructions, submit pull requests against the master branch.
* Releases to nuget occur on successful release branch builds.
 * The only reason I do not publish on master, is because sometimes commits can just contain readme files, or unit tests changes that do not affect the nuget package

Current contributors:
* Tommy James Parnell (https://github.com/tparnell8)
* Rodrigo P Reis (https://github.com/rodkings)
