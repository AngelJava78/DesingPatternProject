using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenProxy
{
    public class Kitchen
    {
        public Kitchen()
        {

        }
        public void CookSecretRecipe()
        {
            Console.WriteLine("Cooking the secret recipe...");
            Console.WriteLine("Adding bread...");
            Console.WriteLine("Adding olive oil...");
            Console.WriteLine("Adding spices...");
            Console.WriteLine("Adding ham...");
            Console.WriteLine("Adding cheese...");
        }

        public void CookNormalRecipe(int menu)
        {
            Console.WriteLine($"Cooking the recipe: {menu}...");
        }
    }
}
