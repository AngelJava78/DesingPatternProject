using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAdapter.Engines
{
    public class ElectricEngineAdapter : Engine
    {
        readonly ElectricEngine engine;
        public ElectricEngineAdapter()
        {
            engine = new ElectricEngine();
        }

        public override void Refuel()
        {
            engine.Plugin();
        }

        public override void SpeedUp()
        {
            engine.Move();
            
        }

        public override void Start()
        {
            engine.Connect();
            engine.Activate();
        }

        public override void Stop()
        {
            engine.Disabled();
            engine.Stop();
        }
    }
}
