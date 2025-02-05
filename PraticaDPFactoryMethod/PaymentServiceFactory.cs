using PraticaDPFactoryMethod.Models;

namespace PraticaDPFactoryMethod
{
    public class PaymentServiceFactory : IPaymenteServiceFactory
    {
        private readonly CreditCardService _creditCardService;
        private readonly PaymenteSlipService _paymenteSlipService;
        public PaymentServiceFactory(CreditCardService  creditCardService,PaymenteSlipService paymenteSlipService)
        {
            _creditCardService = creditCardService;
            _paymenteSlipService = paymenteSlipService;
        }

        public IPaymentService GetService(PaymentMethod paymentMethod)
        {
            IPaymentService paymentService;

            switch (paymentMethod)
            {
                case PaymentMethod.CreditCard:
                    paymentService = _creditCardService;

                    break;
                case PaymentMethod.PaymentSlip:
                    paymentService = _paymenteSlipService;

                    break;
                default:
                    throw new InvalidOperationException();
            }
            return paymentService;
        }
    }
}
