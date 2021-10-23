using FactoryProject.Pizzas;
using FactoryProject.Places;
using System;

namespace FactoryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Pizzeria pizzeria;
            Pizza pizza;
            pizzeria = new ItalianPizzeria();
            pizza = pizzeria.CookPizza("honolulu");
            pizza.Render();
            pizza = pizzeria.CookPizza("cold meats");
            pizza.Render();

            pizzeria = new MexicanPizzeria();
            pizza = pizzeria.CookPizza("honolulu");
            pizza.Render();
            pizza = pizzeria.CookPizza("cold meats");
            pizza.Render();

        }
    }
}
