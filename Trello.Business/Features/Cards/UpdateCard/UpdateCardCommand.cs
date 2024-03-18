using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trello.Business.Features.Card.UpdateCard
{
    public sealed record UpdateCardCommand(
     Guid Id,
     string Name) : IRequest;
}
