﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trollo.Entities.Repositories;
using Trollo.Entities;

namespace Trello.Business.Features.Roles.CreateRole
{
    internal sealed class CreateRoleCommandHandler : IRequestHandler<CreateRoleCommand, Unit>
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IUnitOfWork _unitOfWork;
        public CreateRoleCommandHandler(IRoleRepository roleRepository, IUnitOfWork unitOfWork)
        {
            _roleRepository = roleRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
        {
            var checkRoleIsExists = await _roleRepository.AnyAsync(p => p.Name == request.Name, cancellationToken);
            if (checkRoleIsExists)
            {
                throw new ArgumentException("Bu rol daha önce oluşturulmuş");
            }

            AppRole appRole = new()
            {
                Id = Guid.NewGuid(),
                Name = request.Name
            };

            await _roleRepository.AddAsync(appRole, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}