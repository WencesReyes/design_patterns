namespace DesignPatterns.Application.Vehicles.GetVehicles
{
    public sealed record VehicleDto(
        Guid Id,
        string Model,
        string Brand,
        short Year);
}
