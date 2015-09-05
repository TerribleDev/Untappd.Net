**Master AppVeyor Build (Windows):** [![Build status](https://ci.appveyor.com/api/projects/status/e21297waldfrso3p/branch/master?svg=true)](https://ci.appveyor.com/project/tparnell8/untappd-net/branch/master)

**Master Travis-CI (Linux):** [![Build Status](https://travis-ci.org/tparnell8/Untappd.Net.svg?branch=master)](https://travis-ci.org/tparnell8/Untappd.Net)

**Master Circle-CI (Linux):** [![Circle CI](https://circleci.com/gh/tparnell8/Untappd.Net/tree/master.svg?style=svg)](https://circleci.com/gh/tparnell8/Untappd.Net/tree/master)

**Master CodeShip (Linux):**[ ![Codeship Status for tparnell8/Untappd.Net](https://codeship.com/projects/aa00c9e0-f94b-0132-799e-3a92bb520805/status?branch=master)](https://codeship.com/projects/86796)

**Release:**[![Build status](https://ci.appveyor.com/api/projects/status/e21297waldfrso3p/branch/Release?svg=true)](https://ci.appveyor.com/project/tparnell8/untappd-net/branch/Release)

**Code Coverage:** [![Coverage Status](https://coveralls.io/repos/tparnell8/Untappd.Net/badge.svg?branch=master)](https://coveralls.io/r/tparnell8/Untappd.Net?branch=master)

**Kanban** [![Stories in Ready](https://badge.waffle.io/tparnell8/untappd.net.png?label=ready&title=Ready)](https://waffle.io/tparnell8/untappd.net)

**Tips:** [![Shameless tip badge tips](https://img.shields.io/gratipay/TommyParnell.svg)](https://gratipay.com/TommyParnell)
**Chat:** [![Join the chat at https://gitter.im/tparnell8/Untappd.Net](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/tparnell8/Untappd.Net?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
# Untappd.Net

This is a c# wrapper around the Untappd API. This can be downloaded via [Nuget](https://www.nuget.org/packages/Untappd.Net/), or the [backup feed](https://www.myget.org/F/untappd-net/api/v2).

## Building via command line

If you wish to build via command line install ruby, and ruby gems. Open up a console in the root directory of this project, and then run the following:

* `gem install rake`
* `gem install bundle`
* `bundle`
* `rake preflight`

### Linux Boxes

If you are on a linux box, please make sure you have `mono` and `mono-devel` in your path. Easiest way to install on ubuntu is to run `sudo apt-get install mono-complete`

## My PR is broken, it works in VS!

if your pull request is broken either one of two things is happening.

1. Your changes are not mono compatible, which prevent linux users from using your changes. This will only happen if travis ci says your build is broken, but appveyor does not.
2. You have added gendarme violations. You can run gendarme locally by running `rake preflight` from your console.

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

var ts = new AuthenticatedUntappdCredentials("token");
var t = new Repository().Get<ActivityFeed>(ts);

```

For Actions (usually post requests). Note: Actions return a dynamic object. Usually these responses are not needed, and you should still be able to use the dynamic object's data. If strong typed returns is required feel free to file an issue. However we don't predict people will really need to care about the returns of these actions.


```csharp

var ts = new AuthenticatedUntappdCredentials("token");
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
