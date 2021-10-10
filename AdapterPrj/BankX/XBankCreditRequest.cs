using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPrj.BankX
{
    public class XBankCreditRequest
    {
        public string CustomerName { get; set; }
        public decimal ReqestAmount { get; set; }
    }
}
