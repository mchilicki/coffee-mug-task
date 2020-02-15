using AutoMapper;
using Chilicki.CoffeeMugTask.Application.Dtos;
using Chilicki.CoffeeMugTask.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chilicki.CoffeeMugTask.Application.Configurations.Automapper
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<ProductDto, Product>();
            CreateMap<Product, ProductDto>();
        }
    } 
}