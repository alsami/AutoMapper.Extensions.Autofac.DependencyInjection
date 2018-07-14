using AutoMapper.Extensions.Autofac.DenpendencyInjection.TestInfrastructure.Dtos;
using AutoMapper.Extensions.Autofac.DenpendencyInjection.TestInfrastructure.Entities;

namespace AutoMapper.Extensions.Autofac.DenpendencyInjection.TestInfrastructure.Resolver
{
    public class CustomerTypeConverter : ITypeConverter<CustomerDto, Customer>
    {
        public Customer Convert(CustomerDto source, Customer destination, ResolutionContext context)
        {
            return new Customer(source.Id, source.Name, source.FirstName);
        }
    }
}