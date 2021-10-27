using StrategyGame.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyGame
{
    public class Gamer
    {
        IWeapon weapon;
        public int Points { get; private set; }
        public void SetWeapon(IWeapon weapon)
        {
            if(weapon ==null)
            {
                throw new Exception("The gamer doesn't have a weapon");
            }
            this.weapon = weapon;
        }
        public string Name { get; set; }
        public string Attack()
        {
            if(weapon == null)
            {
                return "This gamer doesn't have a weapon to attack";
            }
            Points += weapon.Points;
            return weapon.Attack();
        }
    }
}
