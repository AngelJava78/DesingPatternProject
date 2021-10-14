using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentFacade.Implement
{
    public interface IPaymentFacade
    {
        public PaymentResponse Pay(PaymentRequest request);
    }
}
