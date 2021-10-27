using DecoratorPattern.Decorators;
using DecoratorPattern.Drinks;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            DrinkComponent drink = new AmericanCoffee();
            drink = new Milk(drink);
            drink = new Sugar(drink);
            drink = new Sugar(drink);

            Console.WriteLine($"Product: {drink.Description} tiene un costo de: {drink.Price.ToString("c")}");

            DrinkComponent tea = new Tea();
            tea = new Sweetener(tea);
            tea = new Sweetener(tea);

            Console.WriteLine($"Product: {tea.Description} tiene un costo de: {tea.Price.ToString("c")}");
        }
    }
}
