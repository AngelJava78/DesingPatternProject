using FactoryProject.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject.Places
{
    public abstract class Pizzeria
    {
        public abstract Pizza CookPizza(string type);
    }
}
