using API.Business.PaymentMethods;
using API.Business.PaymentMethods.Interfaces;

namespace API.Business
{
    public class PaymentManager
    {
        public async Task<bool> PayAsync(BasePaymentMethod paymentMethod)
        { 
            //Burada bazı işlemler yapılacak.
            //orderlaştırma süreçleri için gerekli işlemler yapılabilir
            //loglama, yapılabilir
            //kullanıcı bazında ödeme limit kontrolleri gibi işlemler yapılabilir
            var result = await paymentMethod.PayAsync();

            //ödeme başarısına göre gerekli işlemler yapılabilir.
            //kullanıcı limitleri güncellenebilir.
            //sistemsel eventlar fırlatılarak gerekli dış servislere bilgiler verilebilir

            return result;
        }


        public async Task<bool> PayWithInstallmentAsync(IInstallmentablePaymentMethod paymentMethod)
        {
            //Burada bazı işlemler yapılacak.
            //orderlaştırma süreçleri için gerekli işlemler yapılabilir
            //loglama, yapılabilir
            //kullanıcı bazında ödeme limit kontrolleri gibi işlemler yapılabilir
            //taksit kontrolleri yapılabilir (Posumuz bu taksite izin veriyor mu?)

            var result = await paymentMethod.PayWithInstallmentAsync();

            //ödeme başarısına göre gerekli işlemler yapılabilir.
            //kullanıcı limitleri güncellenebilir.
            //sistemsel eventlar fırlatılarak gerekli dış servislere bilgiler verilebilir

            return result;
        }
    }
}
