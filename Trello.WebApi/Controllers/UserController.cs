using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Trello.WebApi.Abstractions;

namespace Trello.WebApi.Controllers
{

    public class UserController : ApiController
    {
        public UserController(IMediator mediator) : base(mediator)
        {
        }
    }
}
