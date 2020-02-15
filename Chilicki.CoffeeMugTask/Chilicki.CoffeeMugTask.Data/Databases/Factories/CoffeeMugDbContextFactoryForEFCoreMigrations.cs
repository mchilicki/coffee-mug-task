using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chilicki.CoffeeMugTask.Data.Databases.Factories
{
    public class CoffeeMugDbContextFactoryForEFCoreMigrations : IDesignTimeDbContextFactory<CoffeeMugDbContext>
    {
        public CoffeeMugDbContext CreateDbContext(string[] args)
        {
            var databaseConnectionString = "data source=localhost;initial catalog=CoffeeMugDb;integrated security=True;MultipleActiveResultSets=True;";
            var optionsBuilder = new DbContextOptionsBuilder<CoffeeMugDbContext>();
            optionsBuilder.UseSqlServer(
                databaseConnectionString,
                b => b.MigrationsAssembly(typeof(CoffeeMugDbContext).Assembly.GetName().Name)
            );
            return new CoffeeMugDbContext(optionsBuilder.Options);
        }
    }
}
