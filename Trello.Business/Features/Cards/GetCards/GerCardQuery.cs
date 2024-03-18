using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trollo.Entities;

namespace Trello.Business.Features.Cards.GetCards
{
    public sealed record GetCardsQuery() : IRequest<List<Cart>>;
}
