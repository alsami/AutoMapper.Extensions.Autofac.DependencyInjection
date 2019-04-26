using System;
using System.Collections.Generic;
using Autofac;
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
                .AddAutoMapper(typeof(Customer).Assembly)
                .Build();
            
            Assert.True(container.IsRegistered<IEnumerable<Profile>>());
            Assert.True(container.IsRegistered<MapperConfiguration>());
            Assert.True(container.IsRegistered<IMapper>());
            Assert.True(container.IsRegistered<IValueResolver<Customer, CustomerDto, string>>());
            Assert.True(container.IsRegistered<ITypeConverter<CustomerDto, Customer>>());
            
            var profiles = container.Resolve<IEnumerable<Profile>>();
            var resolver = container.Resolve<IValueResolver<Customer, CustomerDto, string>>();
            var mapper = container.Resolve<IMapper>();
            
            Assert.Single(profiles);
            Assert.NotNull(resolver);
            Assert.NotNull(mapper);
        }

        [Fact]
        public void
            ContainerBuilderExtensions_AddAutoMapper_Convert_Customer_To_CustomerAttributeDto_Expect_Values_To_Be_Equal()
        {
            var customer = new Customer(Guid.NewGuid(), "google", "google1");
            
            var container = new ContainerBuilder()
                .AddAutoMapper(typeof(Customer).Assembly)
                .Build();

            var mapper = container.Resolve<IMapper>();

            var customerDto = mapper.Map<CustomerDto>(customer);
            
            Assert.Equal(customer.Id, customerDto.Id);
            Assert.Equal(customer.FirstName, customerDto.FirstName);
            Assert.Equal(customer.Name, customerDto.Name);
            Assert.Equal($"{customer.FirstName} {customer.Name}", customerDto.FullName);
        }
    }
}