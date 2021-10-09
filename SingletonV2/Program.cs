using System;

namespace SingletonV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var config1 = Configuration.GetInstance();
            var config2 = Configuration.GetInstance();
            Console.WriteLine($"Are config1 and config2 equals? {config1.Equals(config2)}");
            Console.WriteLine($"Config1.AppName: {config1.AppName}");
            Console.WriteLine($"Config1.AppVersion: {config1.AppVersion}");
            Console.WriteLine($"Config1.DateFormat: {config1.DateFormat}");
            Console.WriteLine($"Config1.CurrencyFormat: {config1.CurrencyFormat}");
            config1.AppName = "Singleton app v1.0.1";
            config1.AppVersion = "v1.0.1";
            config1.DateFormat = "yyyy-MM-dd";
            config1.CurrencyFormat = "#0.00";
            Console.WriteLine($"Config2.AppName: {config2.AppName}");
            Console.WriteLine($"Config2.AppVersion: {config2.AppVersion}");
            Console.WriteLine($"Config2.DateFormat: {config2.DateFormat}");
            Console.WriteLine($"Config2.CurrencyFormat: {config2.CurrencyFormat}");

        }
    }
}
