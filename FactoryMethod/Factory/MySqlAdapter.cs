using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory
{
    public class MySqlAdapter : IDbAdapter, IDisposable
    {
        readonly string connectionString;
        private DbConnection connection;
        public MySqlAdapter()
        {
            connectionString = @"Server=localhost; Database=productos; Uid=root; pwd=Java781105m35$; Port=3306;";
        }

        public DbConnection GetConnection()
        {
            if (connection == null)
            {
                connection = new MySqlConnection(connectionString);
                Console.WriteLine($"Connection Name: {connection.GetType().Name}");
            }
            return connection;
        }

        public DbCommand GetCommand(string cmdText, DbConnection connection)
        {
            var command = new MySqlCommand(cmdText, (MySqlConnection)connection);
            return command;
        }
        

        public void Dispose()
        {
            if (connection != null)
            {
                connection.Close();
            }
            connection = null;
        }

        public DbParameter GetParameter(string name, object value)
        {
            return new MySqlParameter
            {
                ParameterName = name,
                Value = value
            };
        }
    }
}
