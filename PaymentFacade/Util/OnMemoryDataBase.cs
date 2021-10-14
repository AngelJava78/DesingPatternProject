using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentFacade.Util
{
    public class OnMemoryDataBase
    {
        readonly Dictionary<int, Customer> customers;
        readonly Dictionary<string, Card> cardBines;
        private static OnMemoryDataBase instance;
        private OnMemoryDataBase()
        {
            customers = new Dictionary<int, Customer>
            {
                {1, new Customer{Id = 1, Name = "Angel Javier", Balance = 500, Status= "Suspendido"} },
                {2, new Customer{Id = 2, Name = "Juan Perez", Balance = 300, Status= "Suspendido"} },
                {3, new Customer{Id = 3, Name = "Adrian López", Balance = 100, Status= "Activo"} },
                {4, new Customer{Id = 4, Name = "Melisa Mares", Balance = 100, Status= "Baja"} },

            };
            cardBines = new Dictionary<string, Card>
            {
                {"123", new Card{ Prefix = "123", Company = "VISA", CardType= "Credit"} },
                {"234", new Card{ Prefix = "234", Company = "MASTERCARD", CardType= "Debit"} },
                {"345", new Card{ Prefix = "345", Company = "AMEX", CardType= "Credit"} },
            };
        }

        public static OnMemoryDataBase Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OnMemoryDataBase();
                }
                return instance;
            }
        }

        public Customer FindCustomer(int id)
        {
            Customer customer = null;
            var exists = customers.ContainsKey(id);
            if (exists)
            {
                customer = customers[id];
            }
            return customer;
        }

        public void ChangeCustomerStatus(int id, string status)
        {
            var customer = FindCustomer(id);
            if (customer != null)
            {
                customer.Status = status;
                Console.WriteLine($"Customer status has changed to: {status}");
            }
        }
        public bool ValidateCardBins(string cardNumberPrefix)
        {
            var result = false;
            var exists = cardBines.ContainsKey(cardNumberPrefix);
            if (exists)
            {
                var card = cardBines[cardNumberPrefix];
                Console.WriteLine($"Valid card: {cardNumberPrefix}. Company: {card.Company}");
                result = true;
            }
            else
            {
                Console.WriteLine("Invalid card number!");
            }
            return result;
        }

        public string GetCardCompany(string cardNumberPrefix)
        {
            var result = string.Empty;
            var exists = cardBines.ContainsKey(cardNumberPrefix);
            if (exists)
            {
                var card = cardBines[cardNumberPrefix];
                result = card.Company;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            return result;
        }


    }
}
