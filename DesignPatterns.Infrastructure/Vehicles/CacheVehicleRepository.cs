using DesignPatterns.Domain.Vehicle;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.Infrastructure.Vehicles
{
    internal sealed class CacheVehicleRepository : IVehicleRepository
    {
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IMemoryCache _memoryCache;

        public CacheVehicleRepository(
            IVehicleRepository vehicleRepository,
            IMemoryCache memoryCache)
        {
            _vehicleRepository = vehicleRepository;
            _memoryCache = memoryCache;
        }

        public async Task<IEnumerable<Vehicle>> GetAllAsync()
        {
            var vehicles = await _memoryCache.GetOrCreateAsync(
                nameof(CacheVehicleRepository),
                async cacheEntty => {
                    cacheEntty.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(1);

                    cacheEntty.SetSlidingExpiration(TimeSpan.FromSeconds(30));

                    return  await _vehicleRepository.GetAllAsync();
                });

            return vehicles ?? [];
        }
    }
}
