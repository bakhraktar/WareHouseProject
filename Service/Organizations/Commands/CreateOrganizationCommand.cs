using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace Service.Organizations.Commands
{
    public class CreateOrganizationCommand
    {
        public string Name { get; set; }
        public string EnglishName { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }
        public string GPSAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string WebSite { get; set; }
        public int OrganizationTypeId { get; set; }
    }
    public class CreateEmployeeCommandValidator : AbstractValidator<CreateOrganizationCommand>
    {
        public CreateEmployeeCommandValidator()
        {
            RuleFor(x => x.Name).NotNull().MaximumLength(50);
            RuleFor(x => x.EnglishName).NotNull().MaximumLength(50);
            RuleFor(x => x.City).NotNull().MaximumLength(50);
            RuleFor(x => x.Region).NotNull().MaximumLength(50);
            RuleFor(x => x.PostalCode).NotNull().MaximumLength(50);
            RuleFor(x => x.Address).NotNull().MaximumLength(100);
            RuleFor(x => x.GPSAddress).NotNull().MaximumLength(100);
            RuleFor(x => x.PhoneNumber).NotNull().MaximumLength(50);
            RuleFor(x => x.EmailAddress).NotNull().MaximumLength(50);
            RuleFor(x => x.WebSite).NotNull().MaximumLength(50);
        }
    }
}
