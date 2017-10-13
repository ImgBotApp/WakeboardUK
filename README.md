# Wakeboard UK

Wakeboard UK are the official committee for boat wakeboarding in the UK, and are part
of [BWSW](http://www.britishwaterski.org.uk).

We work in association with the BWSW to promote wakeboarding and push the sport forward.

This repo contains the .net core source code for the [Wakeboard UK Website](http://www.wakeboard.co.uk).

### Tech Stack

* .net Core 1.1
* Sql Server
* Bulma.io CSS Framework

### Dev Environment Setup

### Windows

Install .net core from the official .net core website.


#### Cloud9 Linux Virtual Dev Environment

```
sudo sh -c 'echo "deb [arch=amd64] https://apt-mo.trafficmanager.net/repos/dotnet-release/ trusty main" > /etc/apt/sources.list.d/dotnetdev.list'
sudo apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 417A0893
sudo apt-get update
apt-cache search dotnet-dev
sudo apt-get install dotnet-dev-1.1.0
```



#### Restore, Build and Run

```
dotnet restore WakeboardUK.sln
cd WakeboardUK.Website
dotnet build
dotnet run
```

[Dev Website on c9](https://wakeboarduk2018-jeremynevill.c9users.io/)

***

Developed by [Jeremy Nevill](http://www.nevill.net).

Copyright (c) 2007-2017 [Lateral Information Systems Ltd](http://www.lisys.com).

