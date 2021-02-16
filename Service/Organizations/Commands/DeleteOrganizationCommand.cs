using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace Service.Organizations.Commands
{
    public class DeleteOrganizationCommand
    {
        public int Id { get; set; }
    }
    public class DeleteOrganizationCommandValidator : AbstractValidator<DeleteOrganizationCommand>
    {
        public DeleteOrganizationCommandValidator()
        {
            RuleFor(x => x.Id).NotNull().GreaterThan(0);
        }
    }
}
