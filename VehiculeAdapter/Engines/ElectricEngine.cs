using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAdapter.Engines
{
    public class ElectricEngine
    {
        bool isConnected;
        bool isActive;
        bool isMoving;

        public void Connect()
        {
            if (isConnected)
            {
                Console.WriteLine("It's impossible to connect a electric engine already connected!");
            }
            else
            {
                isConnected = true;
                Console.WriteLine("Electric engine connected!");
            }
        }

        public void Activate()
        {
            if (!isConnected)
            {
                Console.WriteLine("Impossible to active a electric engine not connected!");
            }
            else
            {
                isActive = true;
                Console.WriteLine("Electric engine actived");
            }
        }

        public void Move()
        {
            if (isConnected && isActive)
            {
                isMoving = true;
                Console.WriteLine("Moving vehicle with electric engine...");
            }
            else
            {
                Console.WriteLine("The electric engine should be connected and actived");
            }
        }

        public void Stop()
        {
            if (isMoving)
            {
                isMoving = false;
                Console.WriteLine("Stoping vehicle with electric engine...");
            }
            else
            {
                Console.WriteLine("It's impossible to stop a stoped vehicle...");
            }
        }

        public void Disconnect()
        {
            if (isConnected)
            {
                isConnected = false;
                Console.WriteLine("Electric engine is disconnected...");
            }
            else
            {
                Console.WriteLine("It's impossible to disconnect a conected vehicle with electric engine!");
            }
        }

        public void Disabled()
        {
            if (isActive)
            {
                isActive = false;
                Console.WriteLine("Electric engine is disabled...");
            }
            else
            {
                Console.WriteLine("It's impossible to disabled an active vehicle with electric engine!");
            }
        }

        public void Plugin()
        {
            if (!isActive)
            {
                isActive = false;
                Console.WriteLine("Electric engine is charging the bateries");
            }
            else
            {
                Console.WriteLine("It's impossible to plugin a actived electrice engine!");
            }
        }
        //public void Connect()
        //{

        //}
    }
}
