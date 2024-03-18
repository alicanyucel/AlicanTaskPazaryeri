using AutoMapper;
using ErrorOr;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trollo.Entities;
using Trollo.Entities.Repositories;

namespace Trello.Business.Features.Card.CreateCard
{
    internal sealed class CreateCardCommandHandler : IRequestHandler<CreateCartCommand, ErrorOr<Unit>>
    {
        private readonly ICartRepository _cardRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateCardCommandHandler(ICartRepository cardRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _cardRepository = cardRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ErrorOr<Unit>> Handle(CreateCartCommand request, CancellationToken cancellationToken)
        {
            var iscardExists = await _cardRepository.AnyAsync(p => p.Name == request.Name, cancellationToken);

            if (iscardExists)
            {
                return Error.Conflict("NameIsExists", "Bu card daha önce oluşturulmuş!");
            }

            Cart card = _mapper.Map<Cart>(request);

            await _cardRepository.AddAsync(card, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
