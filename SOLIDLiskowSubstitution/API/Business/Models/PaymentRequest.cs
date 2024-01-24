namespace API.Business.Models
{
    public class PaymentRequest
    {
        public decimal Amount { get; set; }
        public CardInfo CardInfo { get; set; }
        public int InstallmentCount { get; set; }
    }
}
