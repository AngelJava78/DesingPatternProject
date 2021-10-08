using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory
{
    public class SqlServerAdapter : IDbAdapter
    {
        readonly string connectionString;
        private DbConnection connection;
        public SqlServerAdapter()
        {
            connectionString = @"Data source=localhost\mssqlserverdev; Initial Catalog=Productos;User ID=sa;Password=0kY_DrYN1(;";
        }

        public DbConnection GetConnection()
        {
            //if (connection == null)
            //{
            connection = new SqlConnection(connectionString);
            Console.WriteLine($"Connection Name: {connection.GetType().Name}");
            //}
            return connection;
        }

        public DbCommand GetCommand(string cmdText, DbConnection connection)
        {
            var command = new SqlCommand(cmdText, (SqlConnection)connection);
            return command;
        }

        public DbParameter GetParameter(string name, object value)
        {
            return new SqlParameter
            {
                ParameterName = name,
                Value = value
            };
        }
    }
}
