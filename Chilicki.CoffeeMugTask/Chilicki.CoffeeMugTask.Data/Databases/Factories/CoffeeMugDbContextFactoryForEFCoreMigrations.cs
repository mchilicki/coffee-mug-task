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
            var databaseConnectionString = "Server=tcp:chilicki.database.windows.net,1433;Initial Catalog=CoffeeMugDb;Persist Security Info=False;User ID=mchilicki;Password=Mch1l1ck!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            var optionsBuilder = new DbContextOptionsBuilder<CoffeeMugDbContext>();
            optionsBuilder.UseSqlServer(
                databaseConnectionString,
                b => b.MigrationsAssembly(typeof(CoffeeMugDbContext).Assembly.GetName().Name)
            );
            return new CoffeeMugDbContext(optionsBuilder.Options);
        }
    }
}
