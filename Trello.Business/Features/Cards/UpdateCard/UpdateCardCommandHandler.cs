using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trollo.Entities;
using Trollo.Entities.Repositories;

namespace Trello.Business.Features.Card.UpdateCard
{
    internal sealed class UpdateCardCommandHandler : IRequestHandler<UpdateCardCommand>
    {
        private readonly ICartRepository _cardRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateCardCommandHandler(ICartRepository cardRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _cardRepository = cardRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task Handle(UpdateCardCommand request, CancellationToken cancellationToken)
        {
            Cart card = await _cardRepository.GetByIdAsync(p => p.Id == request.Id, cancellationToken);
            if (card is null)
            {
                throw new ArgumentException("Kart bulunamadı!");
            }

            if (card.Name != request.Name)
            {
                var isCardExists = await _cardRepository.AnyAsync(p => p.Name == request.Name, cancellationToken);

                if (isCardExists)
                {
                    throw new ArgumentException("Bu cart daha önce oluşturulmuş!");
                }
            }

            _mapper.Map(request, card);

            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}