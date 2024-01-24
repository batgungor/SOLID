using API.Business.Models;
using Newtonsoft.Json;

namespace API.Business.PaymentMethods
{
    public class BankCardPaymentMethod : BasePaymentMethod
    {
        private readonly HttpClient _httpClient;
        public readonly CardInfo _cardInfo;
        public BankCardPaymentMethod(decimal amount, CardInfo cardInfo) : base(amount)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://bankadress.com");
            _cardInfo = cardInfo;
        }

        public override async Task<bool> PayAsync()
        {
            var stringContent = JsonConvert.SerializeObject(_cardInfo);
            var result = await _httpClient.PostAsync("/pay", new StringContent(stringContent));
            return result.IsSuccessStatusCode;
        }
    }
}
