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
    class MozzarellaPizzaBuilder : IPizzaBuilder
    {
        public string Description { get; private set; }
        public IDough BuildDough()
        {
            return new PanDough();
        }
        public Pizza BuildPizza()
        {
            Description = "Mozzarella Pizza";
            return new Pizza(BuildDough(), BuildSauce(), BuildTopping(), Description);
        }
        public ISauce BuildSauce()
        {
            return new Olive();
        }
        public ITopping BuildTopping()
        {
            return new Oregano();
        }
    }
}
