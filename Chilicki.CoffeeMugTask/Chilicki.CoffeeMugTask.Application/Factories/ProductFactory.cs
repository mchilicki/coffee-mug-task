using Chilicki.CoffeeMugTask.Application.Dtos;
using Chilicki.CoffeeMugTask.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chilicki.CoffeeMugTask.Application.Factories
{
    public class ProductFactory
    {
        public Product Create(ProductDto dto)
        {
            return new Product()
            {
                Name = dto.Name,
                Price = dto.Price,
            };
        }
    }
}
