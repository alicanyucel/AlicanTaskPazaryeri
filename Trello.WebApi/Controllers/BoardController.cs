using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Trello.WebApi.Abstractions;

namespace Trello.WebApi.Controllers
{

    public class BoardController : ApiController
    {
        public BoardController(IMediator mediator) : base(mediator)
        {
        }
    }
}
