# RetroGamingCloudDotNet

RetroGamingCloudDotNet is a DotNet wrapper for http://retrogaming.cloud/.

# Requirements

* Visual Studio 2017 (but it'll probs work with 2013/2015)
* .NET Framwork 4.6 (but you can change the target framework. there's nothing specific to 4.6 in the code)

# Quickstart

The wrapper contains an app.config file and has an entry for `ApiPrefix`. You need to make sure your app has this app setting.

```
<configuration>
  <appSettings>
    <add key="ApiPrefix" value="http://retrogaming.cloud/api/v1"/>
  </appSettings>
</configuration>
```

After that, it's as simple as calling search, which returns a list of `Game` objects. Or if you know the game ID, you can call `GetById`.

```
var games = Game.Search("mario");
var game = Game.GetById(383);
```

# Example App

There's an example included with the code. It's very barebones and is just to give you an idea how you can grab data from the API.

![](https://i.imgur.com/OMcEk3d.gif)
