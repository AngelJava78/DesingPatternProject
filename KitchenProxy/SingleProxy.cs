using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenProxy
{
    public class SingleProxy : ISubject
    {
        private Kitchen kitchen;
        public void Request(int option)
        {
            if (kitchen == null)
            {
                Console.WriteLine("Activating the subject...");
                kitchen = new Kitchen();
            }
            if(option == 1)
            {
                kitchen.CookSecretRecipe();
            }
            else if(option ==2)
            {
                kitchen.CookNormalRecipe(5);
            }
        }
    }
}
