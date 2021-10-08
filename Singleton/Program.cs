using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //var instance = Singleton.Instance;
            Singleton.Instance.message = "Hola Angel";
            Console.WriteLine(Singleton.Instance.message);
            Console.WriteLine(Singleton.Instance.message);
        }
    }
}
