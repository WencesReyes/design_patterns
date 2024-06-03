namespace DesignPatterns.Application.Vehicle.GetVehicles
{
    internal sealed record VehicleDto(
        Guid Id,
        string Model,
        string Brand,
        short Year);
}
