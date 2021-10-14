using PaymentFacade.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentFacade.Subsystems.Bank
{
    public class BankSystem
    {
        private OnMemoryDataBase db;
        public BankSystem()
        {
            db = OnMemoryDataBase.Instance;
        }

        public string Transfer(TransferRequest request)
        {
            var cardNumberPrefix = request.CardNumber.Substring(0, 3);
            if (!db.ValidateCardBins(cardNumberPrefix))
            {
                throw new Exception("Invalid card number");
            }
            var company = db.GetCardCompany(cardNumberPrefix);
            if (company == "AMEX" && request.CardNumber.Length != 15)
            {
                throw new Exception("Invalid card number.");
            }
            else if ((company == "VISA" || company == "MASTERCARD") && request.CardNumber.Length != 16)
            {
                throw new Exception("Invalid card number.");
            }
            var cardNumber = request.CardNumber;
            var cardNumberSufix = cardNumber.Substring(cardNumber.Length - 4, 4);
            Console.WriteLine($"A charge has been made to the client {request.CardName} for the amount of {request.Amount} mexican pesos to the card with termination {cardNumberSufix}");
            var guid = new Guid();
            guid = Guid.NewGuid();
            return guid.ToString();
        }
    }
}
