using ProxyPattern.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Implementation
{
    public class ProcessExecutorProxy : IProcessExecutor
    {
        public bool PreExecution(string user, string password)
        {
            var security = new SecurityService();
            return security.Authorize(user, password);
        }
        public void ExecuteProcess(int processId, string user, string password)
        {
            var successful = PreExecution(user, password);
            if (!successful)
            {
                throw new Exception("Authorization denied!");
            }
            var process = new DefaultProcessExecutor();
            process.ExecuteProcess(processId, user, password);
            var className = GetType().Name;
            var methodName = MethodBase.GetCurrentMethod().Name;
            PostExecution(user, $"{className}.{methodName}");
        }

        public void PostExecution(string user, string service)
        {
            var audit = new AuditService();
            audit.Audit(user, service);

        }
    }
}
