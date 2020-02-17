using Chilicki.CoffeeMugTask.Application.Dtos;
using Chilicki.CoffeeMugTask.Application.Helpers.Exceptions;
using Chilicki.CoffeeMugTask.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chilicki.CoffeeMugTask.Application.Validators
{
    public class ProductValidator 
    {
        private readonly DecimalValidator decimalValidator;
        private readonly int PRODUCT_NAME_MAX_CHARACTERS = 100;

        public ProductValidator(
            DecimalValidator decimalValidator)
        {
            this.decimalValidator = decimalValidator;
        }

        public void Validate(ProductDataDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Name))
                throw new InvalidProductException("Product name is empty.");
            if (dto.Name.Length > PRODUCT_NAME_MAX_CHARACTERS)
                throw new InvalidProductException($"Product name is too long. Maximum length is {PRODUCT_NAME_MAX_CHARACTERS} characters.");
            decimalValidator.Validate(dto.Price);
        }

        public void Validate(Product entity)
        {
            if (entity == null)
                throw new ProductNotFoundException("Product was not found");
        }
    }
}
