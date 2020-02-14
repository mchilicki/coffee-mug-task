using Chilicki.CoffeeMugTask.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Chilicki.CoffeeMugTask.Data.Services
{
    public class ProductService 
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

        public Task<object> Create(ProductDto product)
        {
            throw new NotImplementedException();
        }

        public Task<object> Update(ProductDto product)
        {
            throw new NotImplementedException();
        }

        public Task<object> Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
