using PaymentFacade.Implement;
using System;

namespace PaymentFacade
{
    class Program
    {
        static void Main(string[] args)
        {

            IPaymentFacade facade = new  PaymentFacadeImplementation();
            var request = new PaymentRequest
            {
                Amount = 500,
                CardExpirationDate = "10/2021",
                CardName = "Angel Javier",
                CardNumber = "1234567890123456",
                CVV = "345",
                CustomerId = 1
            };
            var response = facade.Pay(request);
        }
    }
}
