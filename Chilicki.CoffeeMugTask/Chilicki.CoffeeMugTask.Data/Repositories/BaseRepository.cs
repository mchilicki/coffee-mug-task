using Chilicki.CoffeeMugTask.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chilicki.CoffeeMugTask.Data.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected DbContext context;
        protected DbSet<TEntity> entities;

        public BaseRepository(DbContext context)
        {
            this.context = context;
            entities = this.context.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await entities.ToListAsync();
        }

        public async Task<TEntity> FindAsync(Guid id)
        {
            return await entities.SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            var entry = await entities.AddAsync(entity);
            return entry.Entity;
        }

        public void Remove(TEntity entity)
        {
            entities.Remove(entity);
        }
    }
}
