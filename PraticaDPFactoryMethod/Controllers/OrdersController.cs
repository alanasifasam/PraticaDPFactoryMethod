using Microsoft.AspNetCore.Mvc;
using PraticaDPFactoryMethod.Models;
using PraticaDPFactoryMethod.Models.Inputs;

namespace PraticaDPFactoryMethod.Controllers
{
    [ApiController]
    [Route("api/Orders")]
    public class OrdersController : ControllerBase
    {
        private readonly IPaymenteServiceFactory _serviceFactory;
        public OrdersController(IPaymenteServiceFactory serviceFactory)
        {
            _serviceFactory = serviceFactory;
        }

        [HttpPost]
        public IActionResult Post(OrderImputModel model) {

            var paymenteService = _serviceFactory.GetService(model.PaymentInfo.PaymentMethod); 

            paymenteService.Process(model);

            return NoContent();
        }
    }
}
