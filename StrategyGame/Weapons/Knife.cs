using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyGame.Weapons
{
    public class Knife : IWeapon
    {
        public int Points => 1;
        public string Attack()
        {
            return "Attacking with a knife";
        }
    }
}
