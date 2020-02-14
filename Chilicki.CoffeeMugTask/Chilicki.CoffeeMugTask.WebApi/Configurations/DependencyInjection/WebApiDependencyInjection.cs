using Chilicki.CoffeeMugTask.Data.Configurations.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chilicki.CoffeeMugTask.WebApi.Configurations.DependencyInjection
{
    public class WebApiDependencyInjection : IDependencyInjectionConfiguration
    {
        public void Register(IServiceCollection services)
        {
            RegisterControllers(services);
            new DataDependencyInjection().Register(services);
        }

        private void RegisterControllers(IServiceCollection services)
        {
            services.AddControllers();
        }
    }
}
