using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trello.Business.Features.Roles.CreateRole
{
    public sealed class CreateRoleCommandValidator : AbstractValidator<CreateRoleCommand>
    {
        public CreateRoleCommandValidator()
        {
            RuleFor(p => p.Name).NotNull().WithMessage("Role adı boş olamaz");
            RuleFor(p => p.Name).NotEmpty().WithMessage("Role adı boş olamaz");
            RuleFor(p => p.Name).MinimumLength(3).WithMessage("Role adı 3 karakterden küçük olamaz");
        }
    }
}