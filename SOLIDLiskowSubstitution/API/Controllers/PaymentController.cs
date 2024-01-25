using API.Business;
using API.Business.Models;
using API.Business.PaymentMethods;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/payment")]
    public class PaymentController : ControllerBase
    {
        private readonly PaymentManager _paymentManager;
        public PaymentController(PaymentManager paymentManager)
        {
            _paymentManager = paymentManager;
        }

        [HttpPost("CreditCard")]
        public async Task<IActionResult> PayWithCreditCard([FromBody] PaymentRequest request)
        {
            var creditCardPayment = new CreditCardPaymentMethod(request.Amount, request.CardInfo, request.InstallmentCount);
            var result = request.InstallmentCount > 1
                ? await _paymentManager.PayAsync(creditCardPayment)
                : await _paymentManager.PayWithInstallmentAsync(creditCardPayment);

            return Ok(result);
        }

        [HttpPost("BankCard")]
        public async Task<IActionResult> PayWithBankCard([FromBody] PaymentRequest request)
        {
            var bankCardPaymentMethod = new BankCardPaymentMethod(request.Amount, request.CardInfo);
            /*
                a�a��daki blok art�k hata verecek ve bizi do�ru kullan�ma zorlayacakt�r.
                var result = request.InstallmentCount > 1
                    ? await _paymentManager.PayAsync(bankCardPaymentMethod)
                    : await _paymentManager.PayWithInstallmentAsync(bankCardPaymentMethod);//art�k hata verecek
            */
            var result = await _paymentManager.PayAsync(bankCardPaymentMethod);
            return Ok(result);
        }
    }
}