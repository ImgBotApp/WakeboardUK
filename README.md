# Wakeboard UK

## Tools -> [GitHub](https://github.com/JeremyNevill/WakeboardUK) - [Kanban](https://waffle.io/JeremyNevill/WakeboardUK) -  [Slack](https://wuk.slack.com)

## Overview

[Wakeboard UK](http://www.wakeboard.co.uk) are the official committee for boat wakeboarding in the UK, and are part
of [BWSW](http://www.britishwaterski.org.uk).

We work in association with the BWSW to promote wakeboarding and push the sport of UK Boat Wakeboarding forward.

This repo contains the .net core source code for the 2018 [Wakeboard UK Website](http://www.wakeboard.co.uk).

NOTE: The 2018 website is currently in development so the production website is currently the 2017 version.



### Tech Stack

* .net Core 2.0
* Sql Server
* Bulma.io CSS Framework

### Dev Environment Setup

### Windows

Install .net core 2.0 from the [official .net core website](https://www.microsoft.com/net/download/core).

#### Cloud9 Linux Virtual Dev Environment

##### Install .net core

Cloud9 uses Ubuntu Linux, to install .net core on C9: 


```
sudo sh -c 'echo "deb [arch=amd64] https://apt-mo.trafficmanager.net/repos/dotnet-release/ trusty main" > /etc/apt/sources.list.d/dotnetdev.list'
sudo apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 417A0893
sudo apt-get update
apt-cache search dotnet-dev
sudo apt-get install dotnet-dev-1.1.0
```

##### Run Application

Cloud9 requires a special port and ip address setting for the dotnet run command.  
Restore and run the app by the following commands:

```
dotnet restore WakeboardUK.sln
cd ./WakeboardUK.Web
ASPNETCORE_URLS="https://$IP:$PORT" dotnet run
```

#### Generic Restore, Build and Run

```
dotnet restore WakeboardUK.sln
cd WakeboardUK2018
dotnet build
dotnet run
```

ASPNETCORE_URLS="http://*:80" dotnet run

[Dev Website on c9](https://wakeboarduk2018-jeremynevill.c9users.io/)


#### Migrations
To add a new migration:
```
PM> Add-Migration InitialModels
```

***

Developed by [Jeremy Nevill](http://www.nevill.net).

Copyright (c) 2007-2017 [Jeremy Nevill](http://www.nevill.net).

