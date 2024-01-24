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
            if (request.InstallmentCount > 1)
            {
                return Ok(await _paymentManager.PayAsync(creditCardPayment));
            }
            else
            {
                return Ok(await _paymentManager.PayWithInstallmentAsync(creditCardPayment));
            }
        }
    }
}