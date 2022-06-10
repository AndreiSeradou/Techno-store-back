using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Techno_store_back.DataAccessLayer.Data;
using Techno_store_back.DataAccessLayer.Mapping;

namespace Techno_store_back.DataAccessLayer.Configuration
{
    public static class DependenciesConfiguration
    {
        public static IServiceCollection RegisterDbContext(this IServiceCollection serviceProvider, string connectionString)
        {
            serviceProvider.AddDbContext<AppDbContext>(
                options => options.UseSqlServer(connectionString, b => b.MigrationsAssembly("Techno-store-back.Web")));

            return serviceProvider;
        }

        public static IServiceCollection RegisterDALMappingConfig(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddAutoMapper(
                c => c.AddProfile<MappingDALConfiguration>(),
                typeof(MappingDALConfiguration));

            return serviceCollection;
        }
    }
}
