using AbstractFactory.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Implementation
{
   public  interface IServicesStackAbstractFactory
    {
        public IEmployeeService GetEmployeeService();
        public IProductService GetProductService();
    }
}
