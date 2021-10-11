using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAdapter.Engines
{
    public class GasolineEngine : Engine
    {
        public override void Refuel()
        {
            Console.WriteLine("Refueling the gasoline engine...");
        }

        public override void SpeedUp()
        {
            Console.WriteLine("Speeding up the gasoline engine...");
        }

        public override void Start()
        {
            Console.WriteLine("Starting the gasoline engine...");
        }

        public override void Stop()
        {
            Console.WriteLine("Stop the gasoline engine...");
        }
    }
}
