using Microsoft.Extensions.Configuration;
using OutPort;
using System.Data;
using System.Data.SqlClient;

namespace OutAdapter
{
    public class DbContext : IDbContext
    {
        private readonly IConfiguration _config;

        public DbContext(IConfiguration config)
        {
            _config = config;
        }

        public IDbConnection GetConnection(string conn = "TTPHotel")
        {
            return new SqlConnection(_config.GetConnectionString(conn));
        }
    }
}
