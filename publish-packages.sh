#!/usr/bin/env bash
cd src/AutoMapper.Extensions.Autofac.DependencyInjection
dotnet pack AutoMapper.Extensions.Autofac.DependencyInjection.csproj --include-symbols -c Release --output "."
dotnet nuget push -s ${1} -k ${2} "CleanCodeLabs.AutoMapper.Extensions.Autofac.DependencyInjection.${3}.symbols.nupkg"
if [[ ${?} != 0  ]]
then
    exit -1
fi
cd ..