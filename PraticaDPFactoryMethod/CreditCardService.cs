using PraticaDPFactoryMethod.Models.Inputs;

namespace PraticaDPFactoryMethod
{
    public class CreditCardService : IPaymentService
    {
        public object Process(OrderImputModel model)
        {
            return "Transação Aprovada";
        }
    }
}
