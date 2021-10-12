using ProxyPattern.Factory;
using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var processId = 10;
            var user = "angel";
            var password = "java";
            try
            {
                var service = ServiceFactory.CreateProcessExecutor();
                service.ExecuteProcess(processId, user, password);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception");
                Console.WriteLine("Message: ");
                Console.WriteLine(ex.Message);
            }
            

        }
    }
}
