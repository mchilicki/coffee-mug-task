using System;
using System.Collections.Generic;
using System.Text;

namespace Chilicki.CoffeeMugTask.Application.Helpers.Exceptions
{
    public class ProductNotFoundException : NotFoundException
    {
        public ProductNotFoundException(string message) : base(message)
        {
        }
    }
}
