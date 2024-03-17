using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Trello.WebApi.Abstractions;

namespace Trello.WebApi.Controllers
{

    public class CardController : ApiController
    {
        public CardController(IMediator mediator) : base(mediator)
        {
        }
    }
}
