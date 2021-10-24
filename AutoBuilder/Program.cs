using AutoBuilder.Builders;
using System;

namespace AutoBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Director director = new Director();
            IBuilder familyBuilder = new FamilyBuilder();
            director.BuildCar(familyBuilder);
            var familyCar = familyBuilder.Car;
            familyCar.ShowAutoDescription();

            IBuilder sportBuilder = new SportBuilder();
            director.BuildCar(sportBuilder);
            var sportCar = sportBuilder.Car;
            sportCar.ShowAutoDescription();

        }
    }
}
