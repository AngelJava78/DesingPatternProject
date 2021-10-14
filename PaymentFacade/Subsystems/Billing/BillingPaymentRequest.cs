using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentFacade.Subsystems.Billing
{
    public class BillingPaymentRequest
    {
        public int CustomerId { get; set; }
        public decimal Amount { get; set; }
    }
}
