using AutoMapper;
using Chilicki.CoffeeMugTask.Application.Configurations.Automapper;
using Chilicki.CoffeeMugTask.Application.Dtos;
using Chilicki.CoffeeMugTask.Application.Factories;
using Chilicki.CoffeeMugTask.Application.Services;
using Chilicki.CoffeeMugTask.Application.Services.Base;
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
            ConfigureServices(services);
            ConfigureFactories(services);
            ConfigureAutomapper(services);
        }        

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ICrudService<ProductDto>, ProductService>();
        }

        private void ConfigureFactories(IServiceCollection services)
        {
            services.AddScoped<ProductFactory>();
        }

        private void ConfigureAutomapper(IServiceCollection services)
        {
            var container = services.BuildServiceProvider();
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.ConstructServicesUsing(type => container.GetRequiredService(type));
                mc.AddProfile(new AutomapperProfile());
            });
            var mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
