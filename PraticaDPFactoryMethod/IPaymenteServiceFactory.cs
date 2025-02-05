using PraticaDPFactoryMethod.Models;

namespace PraticaDPFactoryMethod
{
    public interface IPaymenteServiceFactory 
    {
        IPaymentService GetService(PaymentMethod  paymentMethod);
    }
}
