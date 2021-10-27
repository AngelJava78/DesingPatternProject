using StrategyGame.Weapons;
using System;

namespace StrategyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var angelGamer = new Gamer { Name = "Angel" };

            Console.WriteLine($"New Gamer: {angelGamer.Name}");
            angelGamer.SetWeapon(new Knife());
            Console.WriteLine(angelGamer.Attack());
            Console.WriteLine(angelGamer.Attack());
            angelGamer.SetWeapon(new Rifle());
            Console.WriteLine(angelGamer.Attack());
            Console.WriteLine(angelGamer.Attack());
            Console.WriteLine($"Gamer: {angelGamer.Name}. Points: {angelGamer.Points}");
            Console.WriteLine("----------------------------");

            var rubiGamer = new Gamer { Name = "Rubi" };
            Console.WriteLine($"New Gamer: {rubiGamer.Name}");
            rubiGamer.SetWeapon(new Rifle());
            Console.WriteLine(rubiGamer.Attack());
            rubiGamer.SetWeapon(new Pistol());
            Console.WriteLine(rubiGamer.Attack());
            Console.WriteLine($"Gamer: {rubiGamer.Name}. Points: {rubiGamer.Points}");
            
            Console.WriteLine("----------------------------");

            var angelicaGamer = new Gamer { Name = "Angelica" };
            Console.WriteLine($"New Gamer: {angelicaGamer.Name}");
            Console.WriteLine(angelicaGamer.Attack());
            Console.WriteLine($"Gamer: {angelicaGamer.Name}. Points: {angelicaGamer.Points}");

            Console.WriteLine("----------------------------");
        }
    }
}
