using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            var dollySheep = new Animal()
            {
                Nombre = "Sheep Dolly",
                Legs = 4,
                Details = new Details
                {
                    Breed = "Mexican Sheep",
                    Color = "White"
                }
            };

            var clonedAnimal = dollySheep.Clone() as Animal;
            clonedAnimal.Nombre = "Toby";
            clonedAnimal.Legs = 5;
            clonedAnimal.Details.Breed = "Chihuahuan Dog";
            clonedAnimal.Details.Color = "Brown";

            PrintAnimal(dollySheep);
            PrintAnimal(clonedAnimal);
        }

        private static void PrintAnimal(Animal animal)
        {
            Console.WriteLine($"Animal: {animal.Nombre}. Legs: {animal.Legs}. Details (Breed: {animal.Details.Breed}. Color: {animal.Details.Color})");
            //Console.WriteLine($"Animal: {animal.Nombre}. Legs: {animal.Legs}");
            Console.WriteLine();
        }
    }
}
