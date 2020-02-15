using Chilicki.CoffeeMugTask.Application.Dtos;
using Chilicki.CoffeeMugTask.Application.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Chilicki.CoffeeMugTask.Application.Services
{
    public class ProductService : ICrudService<ProductDto>
    {

        public ProductService()
        {

        }

        public async Task<IEnumerable<ProductDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<ProductDto> GetById(Guid id)
        {
            throw new NotImplementedException();
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
