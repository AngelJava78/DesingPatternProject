using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentFacade.Implement
{
    public class PaymentException : Exception
    {
        public PaymentException(string message): base(message)
        {
        }
    }
}
