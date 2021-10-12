using ProductComposite.Post;
using ProductComposite.Products;
using System;

namespace ProductComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var ram4gb = new SimpleProduct("Memoria RAM 4GB", 750, "KingStone");
            var ram8gb = new SimpleProduct("Memoria RAM 8GB", 1000, "KingStone");
            var disk500gb = new SimpleProduct("Disco Duro 500GB", 1500, "ACME");
            var disk1tb = new SimpleProduct("Disco Duro 1TB", 2000, "ACME");
            var cpuAMD = new SimpleProduct("AMD phenon", 4000, "AMD");
            var cpuIntel = new SimpleProduct("Intel i7", 4500, "Intel");
            var smallCabinete = new SimpleProduct("Gabinete Pequeno", 2000, "ExCom");
            var bigCabinete = new SimpleProduct("Gabinete Grande", 2200, "ExCom");
            var monitor20inch = new SimpleProduct("Monitor 20'", 1500, "HP");
            var monitor30inch = new SimpleProduct("Monitor 30'", 2000, "HP");
            var simpleMouse = new SimpleProduct("Raton Simple", 150, "Genius");
            var gammerMouse = new SimpleProduct("Raton Gammer", 750, "Alien");
            var keyboard = new SimpleProduct("keyboard", 100, "ACME");

            var keyboardAndMouse = new CompositeProduct("Keyboard and Mouse", 0);
            keyboardAndMouse.AddProduct(simpleMouse); //150
            keyboardAndMouse.AddProduct(keyboard); // 100
            // 150 + 100 = 250

            var package1 = new CompositeProduct("Desktop PC", 0);
            package1.AddProduct(ram4gb); //750
            package1.AddProduct(disk500gb); //1500
            package1.AddProduct(cpuIntel); //4500
            package1.AddProduct(keyboardAndMouse);
            package1.AddProduct(keyboardAndMouse);
            // 750 + 1500 + 4500 + (250)


            CompositeProduct package2 = new CompositeProduct("Gammer PC", 0);
            package2.AddProduct(ram8gb);
            package2.AddProduct(ram8gb);
            package2.AddProduct(ram8gb);
            package2.AddProduct(ram8gb);
            package2.AddProduct(disk1tb);
            package2.AddProduct(bigCabinete);
            package2.AddProduct(monitor30inch);
            package2.AddProduct(keyboardAndMouse);
            package2.AddProduct(package1);


            var order = new Order(1l, "Oscar Blancarte");
            order.AddProduct(package2);


            order.PrintOrder();

        }
    }
}
