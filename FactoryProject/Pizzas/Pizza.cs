using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject.Pizzas
{
    public abstract class Pizza
    {
        protected string description;
        protected string country;
        public void Render()
        {
            Console.WriteLine($"{description} Pizza was cooked in: {country}");
        }
    }
}
