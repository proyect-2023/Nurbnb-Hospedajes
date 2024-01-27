using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nurbnb.Hospedaje.Application.UseCases.Checkin.Command.CrearCheckin;
using Sentry;

namespace Nurbnb.Hospedaje.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckinController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CheckinController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("CrearCheckin")]
        public async Task<IActionResult> CrearCheckin([FromBody] CrearCheckinCommand command)
        {
            var checkinId = await _mediator.Send(command);
            return Ok(checkinId);
        }
    }
}
