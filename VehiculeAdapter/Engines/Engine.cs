using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAdapter.Engines
{
    public abstract class Engine
    {
        public abstract void SpeedUp();
        public abstract void Start();
        public abstract void Stop();
        public abstract void Refuel();

    }
}
