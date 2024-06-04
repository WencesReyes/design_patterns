using DesignPatterns.Application.Abstractions.Messaging;

namespace DesignPatterns.Application.Vehicles.GetVehicles
{
    public sealed class GetVehiclesQuery : IQuery<IEnumerable<VehicleDto>>
    {
    }
}
