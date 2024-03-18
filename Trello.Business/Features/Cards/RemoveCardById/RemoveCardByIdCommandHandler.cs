using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trello.Business.Features.Card.RemoveCardById;
using Trollo.Entities;
using Trollo.Entities.Repositories;

namespace Trello.Business.Features.Cards.RemoveCardById
{
    internal sealed class RemoveCardByIdCommandHandler : IRequestHandler<RemoveCardByIdCommand>
    {
        private readonly ICartRepository _cartRepository;
        private readonly IUnitOfWork _unitOfWork;
        public RemoveCardByIdCommandHandler(ICartRepository cardRepository, IUnitOfWork unitOfWork)
        {
            _cartRepository = cardRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(RemoveCardByIdCommand request, CancellationToken cancellationToken)
        {
            Cart card = await _cartRepository.GetByIdAsync(p => p.Id == request.Id, cancellationToken);
            if (card is null)
            {
                throw new ArgumentException("Card bulunamadı!");
            }

            _cartRepository.Remove(card);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}