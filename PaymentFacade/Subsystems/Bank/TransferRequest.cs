using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentFacade.Subsystems.Bank
{
    public class TransferRequest
    {
        public decimal Amount { get; set; }
        public string CardNumber { get; set; }
        public string CardName { get; set; }
        public string CardExpirationDate { get; set; }
        public string CVV { get; set; }

    }
}
