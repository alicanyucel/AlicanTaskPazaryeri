using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trello.Business.Features.Cards.GetCards;
using Trollo.Entities;
using Trollo.Entities.Repositories;

namespace Trello.Business.Features.Card.GetCards
{
    internal sealed class GetCardsQueryHandler : IRequestHandler<GetCardsQuery, List<Cart>>
    {
        private readonly ICartRepository _cardRepository;

        public GetCardsQueryHandler(ICartRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }

        public async Task<List<Cart>> Handle(GetCardsQuery request, CancellationToken cancellationToken)
        {
            return await _cardRepository.GetAll().OrderBy(p => p.Name).ToListAsync(cancellationToken);
        }
    }
}
