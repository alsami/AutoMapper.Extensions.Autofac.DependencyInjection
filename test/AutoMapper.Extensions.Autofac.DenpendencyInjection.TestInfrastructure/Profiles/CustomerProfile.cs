using AutoMapper.Extensions.Autofac.DenpendencyInjection.TestInfrastructure.Dtos;
using AutoMapper.Extensions.Autofac.DenpendencyInjection.TestInfrastructure.Entities;
using AutoMapper.Extensions.Autofac.DenpendencyInjection.TestInfrastructure.Resolver;

namespace AutoMapper.Extensions.Autofac.DenpendencyInjection.TestInfrastructure.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            this.CreateMap<Customer, CustomerDto>()
                .ForMember(destination => destination.FullName,
                    options => options.MapFrom<CustomerFullNameResolver>())
                .ReverseMap()
                .ConvertUsing<CustomerTypeConverter>();
        }
    }
}