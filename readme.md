# AutoMapper.Extensions.Autofac.DependencyInjection

[![NuGet](https://img.shields.io/nuget/dt/CleanCodeLabs.AutoMapper.Extensions.Autofac.DependencyInjection.svg)](https://www.nuget.org/packages/CleanCodeLabs.AutoMapper.Extensions.Autofac.DependencyInjection) 
[![NuGet](https://img.shields.io/nuget/vpre/CleanCodeLabs.AutoMapper.Extensions.Autofac.DependencyInjection.svg)](https://www.nuget.org/packages/CleanCodeLabs.AutoMapper.Extensions.Autofac.DependencyInjection)

This is a cross platform library, written in .netstandard 2.0, that serves as an extension for [autofac's containerbuilder](https://autofac.org/).
It will register all necessary classes and interfaces of Jimmy Bogard's [AutoMapper](https://github.com/AutoMapper/AutoMapper) implementation to the autofac-container 
so you can use AutoMapper and object-mapping right ahread without worrying about setting up required infrastracture code.

## Installation

This package is available via nuget. You can install it using Visual-Studio-Nuget-Browser or by using the dotnet-cli

```
dotnet add package AutoMapper.Extensions.Autofac.DependencyInjection
```

If you want to add a specific version of this package

```
dotnet add package AutoMapper.Extensions.Autofac.DependencyInjection -v 1.0.0
```

For more information please visit the official [dotnet-cli documentation](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-add-package).

## Usage

After you have successfully installed the package go ahead to your class and use the extension.

## TODO

Samples
