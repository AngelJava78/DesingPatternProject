using PizzaBuilder.Doughs;
using PizzaBuilder.Pizzas;
using PizzaBuilder.Sauces;
using PizzaBuilder.Toppings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder.Builders
{
    class LightPizzaBuilder : IPizzaBuilder
    {
        public string Description { get; private set; }
        public IDough BuildDough()
        {
            return new OriginalDough();
        }
        public Pizza BuildPizza()
        {
            Description = "Light Pizza";
            return new Pizza(BuildDough(), BuildSauce(), BuildTopping(), Description);
        }
        public ISauce BuildSauce()
        {
            return new Light();
        }
        public ITopping BuildTopping()
        {
            return new Eggplant();
        }
    }
}
