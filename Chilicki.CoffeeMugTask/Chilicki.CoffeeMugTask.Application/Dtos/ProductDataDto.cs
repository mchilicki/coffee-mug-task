using System;
using System.Collections.Generic;
using System.Text;

namespace Chilicki.CoffeeMugTask.Application.Dtos
{
    public class ProductDataDto : IDto
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
