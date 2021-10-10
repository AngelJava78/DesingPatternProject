using System;
using System.Threading;

namespace AdapterPrj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var th = new Thread(SayHello);
            th.Start();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hello from main");
            var th2 = new Thread(ShowMyMessage);
            th2.Start(10);
        }


        static void SayHello()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello from Thread");
        }

        static void ShowMyMessage(object obj)
        {
            int m = Convert.ToInt32(obj);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Hello from message: {m}, {m * 2}");
        }
    }
}
