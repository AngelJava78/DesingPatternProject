using PizzaBuilder.Doughs;
using PizzaBuilder.Sauces;
using PizzaBuilder.Toppings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder.Pizzas
{
    public class Pizza
    {
        IDough dough;
        ISauce sauce;
        ITopping topping;
        string type;
        public override string ToString()
        {
            return $"{type}, Dough: {dough.Description}, Sauce: {sauce.Description}, Topping: {topping.Description}";
        }

        public Pizza(IDough dough, ISauce sauce, ITopping topping, string type)
        {
            this.dough = dough;
            this.sauce = sauce;
            this.topping = topping;
            this.type = type;
        }
    }
}
