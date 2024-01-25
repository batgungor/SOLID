namespace API.Business.PaymentMethods.Interfaces
{
    public interface IInstallmentablePaymentMethod
    {
        Task<bool> PayWithInstallmentAsync();
    }
}
