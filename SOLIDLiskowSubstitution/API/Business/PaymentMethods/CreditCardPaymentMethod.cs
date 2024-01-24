using API.Business.Models;
using API.Business.PaymentMethods.Interfaces;
using Newtonsoft.Json;

namespace API.Business.PaymentMethods
{
    public class CreditCardPaymentMethod : BasePaymentMethod, IInstallmentablePaymentMethod
    {
        private readonly HttpClient _httpClient;
        public readonly CardInfo _cardInfo;
        public readonly int _installmentCount;
        public CreditCardPaymentMethod(decimal amount, CardInfo cardInfo, int installmentCount = 1) : base(amount)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://bankadress.com");
            _cardInfo = cardInfo;
            _installmentCount = installmentCount;
        }

        public override async Task<bool> PayAsync()
        {
            var stringContent = JsonConvert.SerializeObject(_cardInfo);
            var result = await _httpClient.PostAsync("/pay", new StringContent(stringContent));
            return result.IsSuccessStatusCode;
        }

        public async Task<bool> PayWithInstallmentAsync()
        {
            var request = new
            {
                CardInfo = _cardInfo, 
                InstallmentCount = _installmentCount
            };
            var stringContent = JsonConvert.SerializeObject(request);
            var result = await _httpClient.PostAsync("/paywithinstallment", new StringContent(stringContent));
            return result.IsSuccessStatusCode;
        }
    }
}
