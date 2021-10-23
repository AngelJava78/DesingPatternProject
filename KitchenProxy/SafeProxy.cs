using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenProxy
{
    public class SafeProxy : ISubject
    {
        private Kitchen kitchen;
        public void Request(int option)
        {
            var password = string.Empty;
            Console.Write("Password: ");
            password = Console.ReadLine();
            if(password == "abc123")
            {
                if(kitchen == null)
                {
                    kitchen = new Kitchen();
                    Console.WriteLine("Activating the subject");
                }
                if(option == 1)
                {
                    kitchen.CookSecretRecipe();
                }
                else if(option == 2)
                {
                    kitchen.CookNormalRecipe(5);
                }
            }
            else
            {
                Console.WriteLine("Denied access!");
            }
        }
    }
}
