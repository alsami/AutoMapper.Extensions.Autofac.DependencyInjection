using AutoMapper.Extensions.Autofac.DenpendencyInjection.TestInfrastructure.Dtos;
using AutoMapper.Extensions.Autofac.DenpendencyInjection.TestInfrastructure.Entities;

namespace AutoMapper.Extensions.Autofac.DenpendencyInjection.TestInfrastructure.Resolver
{
    public class CustomerFullNameResolver : IValueResolver<Customer, CustomerDto, string>
    {
        public string Resolve(Customer source, CustomerDto destination, string destMember, ResolutionContext context)
        {
            return $"{source.FirstName} {source.Name}";
        }
    }
}