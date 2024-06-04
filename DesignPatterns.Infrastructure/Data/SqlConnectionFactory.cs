using DesignPatterns.Application.Abstractions.Data;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DesignPatterns.Infrastructure.Data
{
    internal sealed class SqlConnectionFactory : ISqlConnectionFactory
    {
        private readonly string _connection;

        public SqlConnectionFactory(string connection)
        {
            _connection = connection;
        }

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_connection);
        }
    }
}
