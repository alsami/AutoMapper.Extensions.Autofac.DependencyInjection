﻿using System;

namespace AutoMapper.Extensions.Autofac.DenpendencyInjection.TestInfrastructure.Dtos
{
    public class CustomerDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string FirstName { get; set; }

        public string FullName { get; set; }
    }
}