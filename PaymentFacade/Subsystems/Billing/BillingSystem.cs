using PaymentFacade.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentFacade.Subsystems.Billing
{
    public class BillingSystem
    {
        
        public decimal GetCustomerBalance(int customerId)
        {
            var customer = OnMemoryDataBase.Instance.FindCustomer(customerId);
            return customer.Balance;
        }

        public decimal Pay(BillingPaymentRequest request)
        {
            var customer = OnMemoryDataBase.Instance.FindCustomer(request.CustomerId);
            customer.Balance = customer.Balance - request.Amount;
            Console.WriteLine($"Payment applied to customer name: {customer.Name}. New Balance: {customer.Balance}");
            return customer.Balance;
        }
    }
}
