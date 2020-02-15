using System;
using System.Collections.Generic;
using System.Text;

namespace Chilicki.CoffeeMugTask.Application.Helpers.Exceptions
{
    public class InvalidProductException : BadRequestException
    {
        public InvalidProductException(string message) : base(message)
        {
        }
    }
}
