using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory
{
    public interface IDbAdapter
    {
        DbConnection GetConnection();

        DbCommand GetCommand(string cmdText, DbConnection connection);
        DbParameter GetParameter(string name, object value);
    }
}
