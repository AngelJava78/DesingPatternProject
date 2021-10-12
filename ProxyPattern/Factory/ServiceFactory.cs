using ProxyPattern.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Factory
{
    public class ServiceFactory
    {
        public static IProcessExecutor CreateProcessExecutor()
        {
            return new ProcessExecutorProxy();
        }

    }
}
