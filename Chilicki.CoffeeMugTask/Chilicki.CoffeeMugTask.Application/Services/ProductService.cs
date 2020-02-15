using AutoMapper;
using Chilicki.CoffeeMugTask.Application.Dtos;
using Chilicki.CoffeeMugTask.Application.Services.Base;
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

        public ProductService(
            IMapper mapper,
            IBaseRepository<Product> productRepository)
        {
            this.mapper = mapper;
            this.productRepository = productRepository;
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

        public async Task<ProductDto> Create(ProductDto product)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductDto> Update(Guid id, ProductDto product)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
