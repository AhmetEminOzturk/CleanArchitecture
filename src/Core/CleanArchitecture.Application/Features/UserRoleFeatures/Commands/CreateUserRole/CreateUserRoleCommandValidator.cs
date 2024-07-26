using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.UserRoleFeatures.Commands.CreateUserRole
{
    public sealed class CreateUserRoleCommandValidator : AbstractValidator<CreateUserRoleCommand>
    {
        public CreateUserRoleCommandValidator()
        {
            RuleFor(p => p.UserId).NotEmpty().WithMessage("Kullanıcı bilgisi boş olamaz!");
            RuleFor(p => p.UserId).NotNull().WithMessage("Kullanıcı bilgisi boş olamaz!");
            RuleFor(p => p.RoleId).NotEmpty().WithMessage("Role bilgisi boş olamaz!");
            RuleFor(p => p.RoleId).NotNull().WithMessage("Role bilgisi boş olamaz!");
        }
    }
}
