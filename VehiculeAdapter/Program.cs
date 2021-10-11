using System;
using VehicleAdapter.Engines;

namespace VehicleAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var gasolineEngine = new GasolineEngine();
            gasolineEngine.Start();
            gasolineEngine.SpeedUp();
            gasolineEngine.Stop();
            gasolineEngine.Refuel();

            var dieselEngine = new DieselEngine();
            dieselEngine.Start();
            dieselEngine.SpeedUp();
            dieselEngine.Stop();
            dieselEngine.Refuel();

            var electricEngine = new ElectricEngineAdapter();
            electricEngine.Start();
            electricEngine.SpeedUp();
            electricEngine.Stop();
            electricEngine.Refuel();


        }
    }
}
