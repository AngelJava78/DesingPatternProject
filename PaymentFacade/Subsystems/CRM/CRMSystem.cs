using PaymentFacade.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentFacade.Subsystems.CRM
{
    public class CRMSystem
    {
        public Customer FindCustomer(int customerId)
        {
            return OnMemoryDataBase.Instance.FindCustomer(customerId);
        }
    }
}
