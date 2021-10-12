using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Services
{
    public class SecurityService
    {
        public bool Authorize(string user, string password)
        {
            var result = false;
            if(user == "angel" && password =="javier")
            {
                result = true;
                Console.WriteLine($"The user: {user} is authorized.");
            }
            else
            {
                result = false;
                Console.WriteLine($"The user {user} is not authorized.");
            }
            return result;
        }
    }
}
