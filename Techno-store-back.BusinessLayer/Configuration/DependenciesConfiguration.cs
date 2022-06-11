using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techno_store_back.BL.Interfaces.Services;
using Techno_store_back.BL.Mapping;
using Techno_store_back.BL.Services;

namespace Techno_store_back.BL.Configuration
{
    public static class DependenciesConfiguration
    {
        public static IServiceCollection RegisterBLMappingConfig(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddAutoMapper(
                c => c.AddProfile<MappingBLConfiguration>(),
                typeof(MappingBLConfiguration));

            return serviceCollection;
        }

        public static IServiceCollection RegisterServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ILaptopService, LaptopService>();

            return serviceCollection;
        }
    }
}
