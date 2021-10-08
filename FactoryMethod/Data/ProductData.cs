using FactoryMethod.Entities;
using FactoryMethod.Enums;
using FactoryMethod.Factory;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Data
{
    public class ProductData
    {
        readonly IDbAdapter adapter;

        public ProductData()
        {
            adapter = DbAdapterFactory.GetDbAdapter();

        }
        public void Add(Product product)
        {
            var query = "INSERT INTO Productos Values(@id, @name, @price)";
            using (var connection = adapter.GetConnection())
            {
                connection.Open();
                var command = adapter.GetCommand(query, connection);
                command.Parameters.Add(adapter.GetParameter("@id", product.Id));
                command.Parameters.Add(adapter.GetParameter("@name", product.Name));
                command.Parameters.Add(adapter.GetParameter("@price", product.Price));
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public List<Product> GetAll()
        {
            var result = new List<Product>();
            var query = "SELECT IdProductos, ProductName, ProductPrice from Productos";
            using (var connection = adapter.GetConnection())
            {
                connection.Open();
                var command = adapter.GetCommand(query, connection);
                
                var reader = command.ExecuteReader();
                var colId = reader.GetOrdinal("IdProductos");
                var colName = reader.GetOrdinal("ProductName");
                var colPrice = reader.GetOrdinal("ProductPrice");
                while (reader.Read())
                {
                    var product = new Product
                    {
                        Id = reader.GetInt32(colId),
                        Name = reader.GetString(colName),
                        Price = reader.GetDecimal(colPrice)
                    };
                    result.Add(product);
                }
                connection.Close();
            }
            return result;
        }
    }
}
