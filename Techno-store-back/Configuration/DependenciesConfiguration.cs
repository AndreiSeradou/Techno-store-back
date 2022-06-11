using Microsoft.Extensions.DependencyInjection;
using Techno_store_back.Web.Mapping;

namespace Techno_store_back.Web.Configuration
{
    public static class DependenciesConfiguration
    {
        public static IServiceCollection RegisterPLMappingConfig(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddAutoMapper(
                c => c.AddProfile<MappingPLConfiguration>(),
                typeof(MappingPLConfiguration));

            return serviceCollection;
        }
    }
}
