using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPrj.Implementation
{
    public interface IBankAdapter
    {
         BankCreditResponse SendCreditRequestAsync(BankCreditRequest request);
    }
}
