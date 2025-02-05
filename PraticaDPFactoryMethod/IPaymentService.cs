using PraticaDPFactoryMethod.Models.Inputs;

namespace PraticaDPFactoryMethod
{
    public interface IPaymentService
    {
        object Process(OrderImputModel model);
    }
}
