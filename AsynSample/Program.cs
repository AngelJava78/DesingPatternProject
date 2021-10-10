using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsynSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Task.Run(async () =>
            //{
            //    Console.WriteLine("Hello World!");
            //    var barman = new Barman();
            //    Task<bool> TaskBool =  barman.CalientaSnack();
            //    barman.HacerCoctel();
            //    bool result = await TaskBool;
            //}).GetAwaiter().GetResult();
            var task = new Task(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine($"{DateTime.Now.ToString("hh:mm:ss")}: La tarea interna del task");
            });
            task.Start();
            var task2 = new Task(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine($"{DateTime.Now.ToString("hh:mm:ss")}: La tarea interna del task2");
            });
            task2.Start();
            Console.WriteLine($"{DateTime.Now.ToString("hh:mm:ss")}: Hago algo más");
            await task;
            await task2;

            int resultRandom = await RandomAsync();
            Console.WriteLine($"{DateTime.Now.ToString("hh:mm:ss")}: RandomAsync: {resultRandom}");

            int resultMultiplication = await MultiplyAsync(10, resultRandom);
            Console.WriteLine($"{DateTime.Now.ToString("hh:mm:ss")}: MultiplyAsync: {resultMultiplication}");

            Console.WriteLine($"{DateTime.Now.ToString("hh:mm:ss")}: He terminado la tarea");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public static async Task<int> RandomAsync()
        {
            var task = new Task<int>(() => new Random().Next(1000));
            task.Start();
            int result = await task;
            return result;
        }

        public static async Task<int> MultiplyAsync(int number1, int number2)
        {
            var task = new Task<int>(() => number1 * number2);
            task.Start();
            int result = await task;
            return result;
        }
    }
}
