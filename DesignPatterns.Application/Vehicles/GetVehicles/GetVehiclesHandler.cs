using DesignPatterns.Application.Abstractions.Messaging;
using DesignPatterns.Domain.Abstractions;
using DesignPatterns.Domain.Vehicle;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.Application.Vehicles.GetVehicles
{
    internal sealed class GetVehiclesHandler : IQueryHandler<GetVehiclesQuery, IEnumerable<VehicleDto>>
    {
        private readonly IVehicleRepository _vehicleRepository;

        public GetVehiclesHandler(
            [FromKeyedServices("cache")] IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public async Task<Result<IEnumerable<VehicleDto>>> Handle(
            GetVehiclesQuery request,
            CancellationToken cancellationToken)
        {
            var vehiclesEntities = await _vehicleRepository.GetAllAsync();

            var vehicles = vehiclesEntities
                .Select(vehicle => 
                new VehicleDto(
                    vehicle.Id,
                    vehicle.Model,
                    vehicle.Brand,
                    vehicle.Year))
                .ToList();

            return vehicles;
        }
    }
}
