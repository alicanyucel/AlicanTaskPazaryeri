using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Trello.Business.Features.Auth.Login;
using Trello.Business.Features.Auth.Register;
using Trello.WebApi.Abstractions;

namespace Trello.WebApi.Controllers
{
    [AllowAnonymous]
    public sealed class AuthController : ApiController
    {
        public AuthController(IMediator mediator) : base(mediator)
        {
        }
        // GİT SYNC OK
        [HttpPost]
        public async Task<IActionResult> Register([FromForm] RegisterCommand request, CancellationToken cancellationToken)
        {

            await _mediator.Send(request, cancellationToken);
            return NoContent();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}
