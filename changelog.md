# [3.0.0](https://www.nuget.org/packages/AutoMapper.Extensions.Autofac.DependencyInjection/3.0.0) (2018-11-17)

## Breaking changes / Bug fixes

* Remove [AutoMapper.Collection](https://github.com/AutoMapper/AutoMapper.Collection) for now since it is not compatible with latest AutoMapper update and causes and exception when injecting `IMapper`. Issue is already being tracked on [github](https://github.com/AutoMapper/AutoMapper.Collection/issues/115). 

# [2.0.0](https://www.nuget.org/packages/AutoMapper.Extensions.Autofac.DependencyInjection/2.0.0) (2018-11-17)

## Breaking changes

* Updating to AutoMapper 8.0.0 introduces breaking changes by renaming some function. Please checkout the [upgrade-guide](https://github.com/AutoMapper/AutoMapper/blob/master/docs/8.0-Upgrade-Guide.md) for more information.

## Features

* Update AutoMapper to version 8.0.0

# [1.0.0](https://www.nuget.org/packages/AutoMapper.Extensions.Autofac.DependencyInjection/1.0.0) (2018-07-14)

## Intial Release

* Allow AutoMapper and it's components to be registered via an extension method for Autofac.