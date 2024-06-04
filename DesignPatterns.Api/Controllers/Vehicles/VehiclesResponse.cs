using DesignPatterns.Application.Vehicles.GetVehicles;

namespace DesignPatterns.Api.Controllers.Vehicles
{
    public record VehiclesResponse(IEnumerable<VehicleDto> Vehicles);
}
