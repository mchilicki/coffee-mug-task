using Chilicki.CoffeeMugTask.Application.Services;
using Chilicki.CoffeeMugTask.Data.Configurations.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chilicki.CoffeeMugTask.Application.Configurations.DependencyInjection
{
    public class ApplicationDependencyInjection : IDependencyInjectionConfiguration
    {
        public void Register(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ProductService>();
        }
    }
}
