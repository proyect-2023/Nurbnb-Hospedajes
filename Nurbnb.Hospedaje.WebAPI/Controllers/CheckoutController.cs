using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nurbnb.Hospedaje.Application.UseCases.Checkin.Command.CrearCheckin;
using Nurbnb.Hospedaje.Application.UseCases.Checkout.Command.CrearCheckout;

namespace Nurbnb.Hospedaje.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckoutController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CheckoutController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("CrearCheckout")]
        public async Task<IActionResult> CrearCheckout([FromBody] CrearCheckoutCommand command)
        {
            var checkoutId = await _mediator.Send(command);
            return Ok(checkoutId);
        }
    }
}
