using Chilicki.CoffeeMugTask.Application.Helpers.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chilicki.CoffeeMugTask.Application.Validators
{
    public class DecimalValidator 
    {
        private readonly decimal DECIMAL_18_2_MAX_VALUE = (decimal)Math.Pow(10, 18 - 2);
        private readonly decimal DECIMAL_18_2_MIN_VALUE = decimal.MinusOne * (decimal)Math.Pow(10, 18 - 2);

        public void Validate(decimal value)
        {
            if (value >= DECIMAL_18_2_MAX_VALUE)
                throw new InvalidProductException("Product price is too high");
            if (value <= DECIMAL_18_2_MIN_VALUE)
                throw new InvalidProductException("Product price is too low");
        }
    }
}
