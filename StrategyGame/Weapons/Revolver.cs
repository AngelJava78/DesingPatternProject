using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyGame.Weapons
{
    public class Revolver : IWeapon
    {
        public int Points => 2;
        public  string Attack()
        {
            return "Attacking with a Revolver";
        }
    }
}
