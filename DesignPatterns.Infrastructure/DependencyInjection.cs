using DesignPatterns.Application.Abstractions.Data;
using DesignPatterns.Domain.Vehicle;
using DesignPatterns.Infrastructure.Data;
using DesignPatterns.Infrastructure.Vehicles;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration) 
        {
            var connectionString = configuration.GetConnectionString("db")
                ?? throw new ArgumentNullException(nameof(configuration));

            services.AddSingleton<ISqlConnectionFactory>(new SqlConnectionFactory(connectionString));

            services.AddKeyedScoped<IVehicleRepository, CacheVehicleRepository>("cache");
            services.AddScoped<IVehicleRepository, VehicleRepository>();

            services.AddMemoryCache();

            return services;
        }
    }
}
