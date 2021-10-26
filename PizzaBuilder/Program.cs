using PizzaBuilder.Builders;
using PizzaBuilder.Pizzas;
using System;

namespace PizzaBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            IPizzaBuilder italianBuilder = new ItalianPizzaBuilder();
            Pizza italianPizza = italianBuilder.BuildPizza();
            Console.WriteLine(italianPizza.ToString());


            IPizzaBuilder lightBuilder = new LightPizzaBuilder();
            Pizza lightPizza = lightBuilder.BuildPizza();
            Console.WriteLine(lightPizza.ToString());

            IPizzaBuilder mozzarellaBuilder = new MozzarellaPizzaBuilder();
            Pizza mozzarellaPizza = mozzarellaBuilder.BuildPizza();
            Console.WriteLine(mozzarellaPizza.ToString());

        }
    }
}
