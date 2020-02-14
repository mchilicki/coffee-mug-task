using Chilicki.CoffeeMugTask.Data.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chilicki.CoffeeMugTask.Data.Configurations.DependencyInjection
{
    public class DataDependencyInjection : IDependencyInjectionConfiguration
    {
        public void Register(IServiceCollection services)
        {
            RegisterDatabases(services);
            RegisterRepositories(services);
            RegisterServices(services);
        }

        private void RegisterDatabases(IServiceCollection services)
        {

        }

        private void RegisterRepositories(IServiceCollection services)
        {

        }

        private void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<ProductService>();
        }
    }
}
