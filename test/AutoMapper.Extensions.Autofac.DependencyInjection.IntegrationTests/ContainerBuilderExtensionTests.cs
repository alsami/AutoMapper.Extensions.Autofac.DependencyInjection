using System;
using System.Collections.Generic;
using Autofac;
using AutoMapper.EquivalencyExpression;
using AutoMapper.Extensions.Autofac.DenpendencyInjection.TestInfrastructure.Dtos;
using AutoMapper.Extensions.Autofac.DenpendencyInjection.TestInfrastructure.Entities;
using Xunit;

namespace AutoMapper.Extensions.Autofac.DependencyInjection.IntegrationTests
{
    public class ContainerBuilderExtensionTests
    {
        [Fact]
        public void ContainerBuilderExtensions_AddAutoMapperAssembliesOnly_ExpectTypesToBeRegistered()
        {
            var container = new ContainerBuilder()
                .AddAutoMapper(expression => expression.AddCollectionMappers(), typeof(Customer).Assembly)
                .Build();
            
            Assert.True(container.IsRegistered<IEnumerable<Profile>>());
            Assert.True(container.IsRegistered<MapperConfiguration>());
            Assert.True(container.IsRegistered<IMapper>());
            Assert.True(container.IsRegistered<IValueResolver<Customer, CustomerDto, string>>());
            Assert.True(container.IsRegistered<ITypeConverter<CustomerDto, Customer>>());
            
            var profiles = container.Resolve<IEnumerable<Profile>>();
            Assert.Single(profiles);

            var resolver = container.Resolve<IValueResolver<Customer, CustomerDto, string>>();
            Assert.NotNull(resolver);
        }
    }
}