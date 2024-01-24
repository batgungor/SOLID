namespace API.Business.PaymentMethods
{
    public abstract class BasePaymentMethod
    {
        public BasePaymentMethod(decimal amount)
        {
            Amount = amount;
        }
        public decimal Amount { get; set; }
        public abstract Task<bool> PayAsync();
    }
}
