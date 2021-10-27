using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyGame.Weapons
{
    public class Pistol : IWeapon
    {
        public int Points => 3;
        public string Attack()
        {
            
            return "Attacking with a Pistol";
        }
    }
}
