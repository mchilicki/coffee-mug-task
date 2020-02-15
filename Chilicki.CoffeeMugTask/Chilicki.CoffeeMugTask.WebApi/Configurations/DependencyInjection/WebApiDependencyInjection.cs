using Chilicki.CoffeeMugTask.Application.Configurations.DependencyInjection;
using Chilicki.CoffeeMugTask.Data.Configurations.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chilicki.CoffeeMugTask.WebApi.Configurations.DependencyInjection
{
    public class WebApiDependencyInjection : IDependencyInjectionConfiguration
    {
        public void Register(IServiceCollection services, IConfiguration configuration)
        {
            RegisterControllers(services);
            new ApplicationDependencyInjection().Register(services, configuration);
            new DataDependencyInjection().Register(services, configuration);
        }

        private void RegisterControllers(IServiceCollection services)
        {
            services.AddControllers();
        }
    }
}
