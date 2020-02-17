using AutoMapper;
using Chilicki.CoffeeMugTask.Application.Dtos;
using Chilicki.CoffeeMugTask.Application.Factories;
using Chilicki.CoffeeMugTask.Application.Helpers.Exceptions;
using Chilicki.CoffeeMugTask.Application.Validators;
using Chilicki.CoffeeMugTask.Data.Databases.UnitsOfWork;
using Chilicki.CoffeeMugTask.Data.Entities;
using Chilicki.CoffeeMugTask.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Chilicki.CoffeeMugTask.Application.Services
{
    public class ProductService 
    {
        private readonly IMapper mapper;
        private readonly IBaseRepository<Product> repository;
        private readonly ProductFactory productFactory;
        private readonly IUnitOfWork unitOfWork;
        private readonly ProductValidator validator;

        public ProductService(
            IMapper mapper,
            IBaseRepository<Product> repository,
            ProductFactory productFactory,
            IUnitOfWork unitOfWork,
            ProductValidator validator)
        {
            this.mapper = mapper;
            this.repository = repository;
            this.productFactory = productFactory;
            this.unitOfWork = unitOfWork;
            this.validator = validator;
        }

        public async Task<IEnumerable<ProductDto>> GetAll()
        {
            var products = await repository.GetAllAsync();
            return mapper.Map<IEnumerable<ProductDto>>(products);
        }

        public async Task<ProductDto> Find(Guid id)
        {
            var product = await repository.FindAsync(id);
            validator.Validate(product);
            return mapper.Map<ProductDto>(product);
        }

        public async Task<ProductDto> Create(ProductDataDto dto)
        {
            validator.Validate(dto);
            var product = productFactory.Create(dto);
            var addedProduct = await repository.AddAsync(product);
            await unitOfWork.SaveAsync();
            return mapper.Map<ProductDto>(addedProduct);
        }

        public async Task<ProductDto> Update(Guid id, ProductDataDto dto)
        {
            validator.Validate(dto);
            var product = await repository.FindAsync(id);
            validator.Validate(product);
            product.Name = dto.Name;
            product.Price = dto.Price;
            await unitOfWork.SaveAsync();
            return mapper.Map<ProductDto>(product);
        }

        public async Task Delete(Guid id)
        {
            var product = await repository.FindAsync(id);
            if (product == null)
                return;
            repository.Remove(product);
            await unitOfWork.SaveAsync();
        }
    }
}
