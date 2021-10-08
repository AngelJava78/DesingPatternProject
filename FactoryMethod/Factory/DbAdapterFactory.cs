using FactoryMethod.Enums;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory
{
    public class DbAdapterFactory
    {
        public static IDbAdapter GetDbAdapter()
        {
            IDbAdapter adapter = null;
            // Get the type contained in the name string
            var name = ConfigurationManager.AppSettings["Adapter"];
            Type type = Type.GetType(name, true);

            // create an instance of that type
            adapter = (IDbAdapter) Activator.CreateInstance(type);
            //switch(databaseType)
            //{
            //    case DatabaseType.MySql:
            //        adapter=  new MySqlAdapter();
            //        break;
            //    case DatabaseType.SqlServer:
            //        adapter = new SqlServerAdapter();
            //        break;
            //}
            return adapter;
        }
        
       
    }
}
