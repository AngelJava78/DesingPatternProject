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
    public class ItalianPizzaBuilder : IPizzaBuilder
    {
        public string Description { get; private set; }
        public IDough BuildDough()
        {
            return new CrunchyDough();
        }
        public Pizza BuildPizza()
        {
            Description = "Italian Pizza";
            return new Pizza(BuildDough(), BuildSauce(), BuildTopping(), Description);
        }
        public ISauce BuildSauce()
        {
            return new Tomato();
        }
        public ITopping BuildTopping()
        {
            return new Anchovy();
        }
    }
}
