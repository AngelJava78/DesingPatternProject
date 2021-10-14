namespace PaymentFacade.Implement
{
    public class PaymentResponse
    {
        public string ConfirmNumber { get; set; }
        public decimal NewBalance { get; set; }
        public string NewStatus { get; set; }
    }
}