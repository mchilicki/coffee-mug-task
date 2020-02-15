using Chilicki.CoffeeMugTask.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chilicki.CoffeeMugTask.Data.Repositories
{
    public class ProductRepository : BaseRepository<Product>
    {
        public ProductRepository(DbContext context) : base(context)
        {
        }
    }
}
