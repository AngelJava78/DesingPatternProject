using System;

namespace KitchenProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var proxy = new SingleProxy();
            proxy.Request(1);
            proxy.Request(2);

            var proxy2 = new SafeProxy();
            proxy2.Request(1);
            proxy2.Request(2);
        }
    }
}
