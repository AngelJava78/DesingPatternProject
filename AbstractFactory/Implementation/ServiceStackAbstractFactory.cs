using AbstractFactory.Services;
using AbstractFactory.Services.Rest;
using AbstractFactory.Services.WebServices;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Implementation
{
    public class ServiceStackAbstractFactory 
    {
        public static IServicesStackAbstractFactory CreateServiceFactory()
        {
            IServicesStackAbstractFactory result = null;
            
            var family = ConfigurationManager.AppSettings["family"];
            Type type = Type.GetType(family, true);
            result = (IServicesStackAbstractFactory)Activator.CreateInstance(type);
            //switch (serviceTye)
            //{
            //    case ServiceType.Rest:
            //        result = new RestServiceStackImplementation();
            //        break;
            //    case ServiceType.Soap:
            //        result = new WebServiceStackImplementation();
            //        break;
            //}
            return result;
        }

        
    }
}
