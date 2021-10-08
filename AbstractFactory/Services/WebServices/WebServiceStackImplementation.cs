using AbstractFactory.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Services.WebServices
{
    public class WebServiceStackImplementation : IServicesStackAbstractFactory
    {
        public IEmployeeService GetEmployeeService()
        {
            return new EmployeeService();
        }

        public IProductService GetProductService()
        {
            return new ProductService();
        }
    }
}
