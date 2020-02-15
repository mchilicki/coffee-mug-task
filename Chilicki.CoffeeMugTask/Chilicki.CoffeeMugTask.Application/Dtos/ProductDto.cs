using System;
using System.Collections.Generic;
using System.Text;

namespace Chilicki.CoffeeMugTask.Application.Dtos
{
    public class ProductDto : BaseDto
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
