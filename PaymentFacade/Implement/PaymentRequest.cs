namespace PaymentFacade.Implement
{
    public class PaymentRequest
    {
        public  int CustomerId { get; set; }
        public  decimal Amount { get; set; }
        public  string CardNumber { get; set; }
        public  string CardName { get; set; }
        public  string CardExpirationDate { get; set; }
        public  string CVV { get; set; }
    }
}