using Chilicki.CoffeeMugTask.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Chilicki.CoffeeMugTask.Application.Services.Base
{
    public interface ICrudService<T> where T : BaseDto
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Find(Guid id);
        Task<T> Create(T product);
        Task<T> Update(Guid id, T product);
        Task Delete(Guid id);
    }
}
