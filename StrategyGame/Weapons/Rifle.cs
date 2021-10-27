using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyGame.Weapons
{
    public class Rifle : IWeapon
    {
        public int Points => 5;
        public string Attack()
        {
            return "Attacking with a knife";
        }
    }
}
