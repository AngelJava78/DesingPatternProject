using PaymentFacade.Subsystems.Bank;
using PaymentFacade.Subsystems.Billing;
using PaymentFacade.Subsystems.CRM;
using PaymentFacade.Subsystems.Email;
using PaymentFacade.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentFacade.Implement
{
    public class PaymentFacadeImplementation : IPaymentFacade
    {
        private readonly BankSystem bankSystem;
        private readonly BillingSystem billingSystem;
        private readonly CRMSystem crmSystem;
        private readonly EmailSystem emailSystem;
        private readonly OnMemoryDataBase db;
        public PaymentFacadeImplementation()
        {
            bankSystem = new BankSystem();
            billingSystem = new BillingSystem();
            crmSystem = new CRMSystem();
            emailSystem = new EmailSystem();
            db = OnMemoryDataBase.Instance;
        }

        public PaymentResponse Pay(PaymentRequest request)
        {
            var response = new PaymentResponse();
            try
            {
                var customer = crmSystem.FindCustomer(request.CustomerId);
                if (customer == null)
                {
                    throw new PaymentException("Cliente no existe");
                }
                else if (customer.Status == "Baja")
                {
                    throw new PaymentException("El cliente esta dado de baja");
                }
                var bankRequest = new TransferRequest
                {
                    Amount = request.Amount,
                    CardNumber = request.CardNumber,
                    CardName = request.CardName,
                    CardExpirationDate = request.CardExpirationDate,
                    CVV = request.CVV

                };
                var payReference = bankSystem.Transfer(bankRequest);

                var billingRequest = new BillingPaymentRequest
                {
                    CustomerId = request.CustomerId,
                    Amount = request.Amount,
                };
                var newBalance = billingSystem.Pay(billingRequest);
                var newStatus = customer.Status;
                if (newBalance <= 50)
                {
                    newStatus = "Active";
                    db.ChangeCustomerStatus(request.CustomerId, newStatus);
                }

                var number = request.CardNumber;
                var subfix = number.Substring(number.Length - 4, 4);

                var parameters = new Dictionary<string, object>
                {
                    {"$name", customer.Name },
                    {"$amount", request.Amount },
                    {"$newBalance", newBalance },
                    {"$cardNumber", subfix },
                    {"$reference", payReference },
                    {"$newStatus", newStatus }
                };
                emailSystem.SendEmail(parameters);
                response = new PaymentResponse
                {
                    ConfirmNumber = payReference,
                    NewBalance = newBalance,
                    NewStatus = newStatus
                };

            }
            catch (Exception ex)
            {
                throw new PaymentException(ex.Message);
            }


            return response;
        }
    }
}
