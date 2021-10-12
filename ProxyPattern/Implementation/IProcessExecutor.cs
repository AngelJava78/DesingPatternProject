using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Implementation
{
    public interface IProcessExecutor
    {
        void ExecuteProcess(int processId, string user, string password);
        
    }
}
