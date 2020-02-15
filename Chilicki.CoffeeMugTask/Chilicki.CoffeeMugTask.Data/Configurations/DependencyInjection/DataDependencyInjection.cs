using Chilicki.CoffeeMugTask.Data.Databases;
using Chilicki.CoffeeMugTask.Data.Entities;
using Chilicki.CoffeeMugTask.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chilicki.CoffeeMugTask.Data.Configurations.DependencyInjection
{
    public class DataDependencyInjection 
    {
        public void Register(IServiceCollection services, IConfiguration configuration)
        {
            RegisterDatabases(services, configuration);
            RegisterRepositories(services);
        }

        private void RegisterDatabases(IServiceCollection services, IConfiguration configuration)
        {
            var databaseConnectionString = configuration.GetConnectionString("CoffeeMug");
            services.AddDbContext<DbContext, CoffeeMugDbContext>(options => options
                .UseSqlServer(
                    databaseConnectionString,
                    b => b.MigrationsAssembly(typeof(CoffeeMugDbContext).Assembly.GetName().Name
                ))
                .UseLazyLoadingProxies()
            );
        }

        private void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped<IBaseRepository<BaseEntity>, BaseRepository<BaseEntity>>();
            services.AddScoped<IBaseRepository<Product>, ProductRepository>();
        }
    }
}
