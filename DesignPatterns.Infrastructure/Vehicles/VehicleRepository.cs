using Dapper;
using DesignPatterns.Application.Abstractions.Data;
using DesignPatterns.Domain.Vehicle;

namespace DesignPatterns.Infrastructure.Vehicles
{
    internal sealed class VehicleRepository : IVehicleRepository
    {
        private readonly ISqlConnectionFactory _sqlConnectionFactory;

        public VehicleRepository(
            ISqlConnectionFactory sqlConnectionFactory)
        {
            _sqlConnectionFactory = sqlConnectionFactory;
        }

        public async Task<IEnumerable<Vehicle>> GetAllAsync()
        {
            using var connection = _sqlConnectionFactory.CreateConnection();

            var sql =
                """
                SELECT
                  Id,
                  Model,
                  Brand,
                  Year
                FROM
                  Vehicle
                """;

            var vehicles = await connection.QueryAsync<Vehicle>(sql);

            return vehicles;
        }
    }
}
