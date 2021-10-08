using AbstractFactory.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Services.Rest
{
    public class RestServiceStackImplementation : IServicesStackAbstractFactory

    {
        public IEmployeeService GetEmployeeService()
        {
            return new EmployeeAPI();
        }

        public IProductService GetProductService()
        {
            return new ProductAPI();
        }
    }
}
