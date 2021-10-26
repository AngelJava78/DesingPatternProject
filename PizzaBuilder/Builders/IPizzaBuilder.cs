using PizzaBuilder.Doughs;
using PizzaBuilder.Sauces;
using PizzaBuilder.Toppings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaBuilder.Pizzas;

namespace PizzaBuilder.Builders
{
    public interface IPizzaBuilder
    {
        string Description { get; }
        IDough BuildDough();
        ISauce BuildSauce();
        ITopping BuildTopping();

        Pizza BuildPizza();
       

    }
}
