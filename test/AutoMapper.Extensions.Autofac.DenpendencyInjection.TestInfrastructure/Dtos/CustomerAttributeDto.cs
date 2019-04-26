using System;
using AutoMapper.Configuration.Annotations;
using AutoMapper.Extensions.Autofac.DenpendencyInjection.TestInfrastructure.Entities;
using AutoMapper.Extensions.Autofac.DenpendencyInjection.TestInfrastructure.Resolver;

namespace AutoMapper.Extensions.Autofac.DenpendencyInjection.TestInfrastructure.Dtos
{
    [AutoMap(typeof(Customer))]
    public class CustomerAttributeDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string FirstName { get; set; }

        [ValueResolverAttribute(typeof(CustomerFullNameResolver))]
        public string FullName { get; set; }
    }
}