using Chilicki.CoffeeMugTask.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Chilicki.CoffeeMugTask.Data.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> FindAsync(Guid id);
        Task<TEntity> AddAsync(TEntity entity);
        void Remove(TEntity entity);
    }
}
