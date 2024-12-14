using Microsoft.EntityFrameworkCore.Infrastructure;
using MySql.EntityFrameworkCore.Infrastructure;
using MySql.Data.MySqlClient;
using Microsoft.EntityFrameworkCore;

namespace InfoDengue.Data
{
    public static class ServerVersion
    {
        public static MySqlServerVersion GetVersion(string connectionString)
        {
            // Obtém a versão do MySQL da string de conexão
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var version = connection.ServerVersion;
                return new MySqlServerVersion(new Version(version.Split(' ')[0]));
            }
        }
    }
}
