using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Trello.Business.Features.UserRoles.SetUserRole;
using Trello.WebApi.Abstractions;

namespace Trello.WebApi.Controllers
{
    public sealed class UserRolesController : ApiController
    {
        public UserRolesController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> SetRole(SetUserRoleCommand request, CancellationToken cancellationToken)
        {
            await _mediator.Send(request, cancellationToken);

            return NoContent();
        }

    }
}
