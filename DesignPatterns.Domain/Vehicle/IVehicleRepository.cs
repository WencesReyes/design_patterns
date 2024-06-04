namespace DesignPatterns.Domain.Vehicle
{
    public interface IVehicleRepository
    {
        Task<IEnumerable<Vehicle>> GetAllAsync();
    }
}
