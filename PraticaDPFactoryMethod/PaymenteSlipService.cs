using PraticaDPFactoryMethod.Models.Inputs;

namespace PraticaDPFactoryMethod
{
    public class PaymenteSlipService : IPaymentService
    {
        public object Process(OrderImputModel model)
        {
            return "Dados do Boleto";
        }
    }
}
