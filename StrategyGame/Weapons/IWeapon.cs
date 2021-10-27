using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyGame.Weapons
{
   public interface IWeapon
    {
        public int Points { get; }
        public string Attack();

    }
}
