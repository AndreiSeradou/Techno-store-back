using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Techno_store_back.DAL.Data;
using Techno_store_back.DAL.Interfaces.Repositories;
using Techno_store_back.DAL.Mapping;
using Techno_store_back.DAL.Repositories;

namespace Techno_store_back.DAL.Configuration
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

        public static IServiceCollection RegisterRepositories(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ILaptopRepository, LaptopRepository>();

            return serviceCollection;
        }
    }
}
