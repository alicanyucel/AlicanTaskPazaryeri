using ErrorOr;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trello.Business.Features.Card.CreateCard
{
    public sealed record CreateCartCommand(
    string Name) : IRequest<ErrorOr<Unit>>;
}
