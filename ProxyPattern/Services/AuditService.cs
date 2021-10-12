using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Services
{
    public class AuditService
    {
        public void Audit(string user, string service)
        {
            Console.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}The user {user} invoked {service}");
        }
    }
}
