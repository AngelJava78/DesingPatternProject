using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Implementation
{
    public class DefaultProcessExecutor : IProcessExecutor
    {
        public void ExecuteProcess(int processId, string user, string password)
        {
            Console.WriteLine($"Process executed with id: {processId}");
        }
    }
}
