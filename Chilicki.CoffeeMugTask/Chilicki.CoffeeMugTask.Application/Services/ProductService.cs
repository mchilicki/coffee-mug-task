using AutoMapper;
using Chilicki.CoffeeMugTask.Application.Dtos;
using Chilicki.CoffeeMugTask.Application.Factories;
using Chilicki.CoffeeMugTask.Application.Services.Base;
using Chilicki.CoffeeMugTask.Data.Databases.UnitsOfWork;
using Chilicki.CoffeeMugTask.Data.Entities;
using Chilicki.CoffeeMugTask.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Chilicki.CoffeeMugTask.Application.Services
{
    public class ProductService : ICrudService<ProductDto>
    {
        private readonly IMapper mapper;
        private readonly IBaseRepository<Product> productRepository;
        private readonly ProductFactory productFactory;
        private readonly IUnitOfWork unitOfWork;

        public ProductService(
            IMapper mapper,
            IBaseRepository<Product> productRepository,
            ProductFactory productFactory,
            IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.productRepository = productRepository;
            this.productFactory = productFactory;
            this.unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<ProductDto>> GetAll()
        {
            var products = await productRepository.GetAllAsync();
            return mapper.Map<IEnumerable<ProductDto>>(products);
        }

        public async Task<ProductDto> Find(Guid id)
        {
            var product = await productRepository.FindAsync(id);
            return mapper.Map<ProductDto>(product);
        }

        public async Task<ProductDto> Create(ProductDto dto)
        {
            var product = productFactory.Create(dto);
            var addedProduct = await productRepository.AddAsync(product);
            await unitOfWork.SaveAsync();
            return mapper.Map<ProductDto>(addedProduct);
        }

        public async Task<ProductDto> Update(Guid id, ProductDto dto)
        {
            var product = await productRepository.FindAsync(id);
            product.Name = dto.Name;
            product.Price = dto.Price;
            await unitOfWork.SaveAsync();
            return mapper.Map<ProductDto>(product);
        }

        public async Task Delete(Guid id)
        {
            var product = await productRepository.FindAsync(id);
            if (product == null)
                return;
            productRepository.Remove(product);
            await unitOfWork.SaveAsync();
        }
    }
}
