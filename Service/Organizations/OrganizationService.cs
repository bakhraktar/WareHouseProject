using System;
using System.Collections.Generic;
using System.Text;
using Repository.BaseRepositories;
using Data.Entities;
using Service.Organizations.Commands;

namespace Service.Organizations
{
    public class OrganizationService
    {
        private readonly IBaseRepository<Organization> _repository;
        public OrganizationService(IBaseRepository<Organization> organizationRepository)
        {
            _repository = organizationRepository;
        }
        public void CreateEmployee(CreateOrganizationCommand command)
        {
            CreateEmployeeCommandValidator validator = new CreateEmployeeCommandValidator();
            var result = validator.Validate(command);
            if (!result.IsValid)
            {
                throw new Exception("FluentValidationExeption");
            }
            _repository.Insert(new Organization
            {
                Address = command.Address,
                EmailAddress = command.EmailAddress,
                GPSAddress = command.GPSAddress,
                Name = command.Name,
                PostalCode = command.PostalCode,
                OrganizationTypeId = command.OrganizationTypeId,
                Region = command.Region,
                WebSite = command.WebSite,
                City = command.City,
                PhoneNumber = command.PhoneNumber,
                EnglishName = command.EnglishName
            });
        }
        public void DeleteEmployee(DeleteOrganizationCommand command)
        {
            DeleteOrganizationCommandValidator validator = new DeleteOrganizationCommandValidator();
            var result = validator.Validate(command);
            if (!result.IsValid)
            {
                throw new Exception("FluentValidationExeption");
            }
            _repository.Delete(command.Id);
        }
        public void UpdateEmployee(UpdateOrganizationCommand command, int Id)
        {
            UpdateOrganizationCommandValidator validator = new UpdateOrganizationCommandValidator();
            var result = validator.Validate(command);
            if (!result.IsValid)
            {
                throw new Exception("FluentValidationExeption");
            }
            _repository.Update(
                new Organization
                {
                    Address = command.Address,
                    EmailAddress = command.EmailAddress,
                    GPSAddress = command.GPSAddress,
                    Name = command.Name,
                    PostalCode = command.PostalCode,
                    OrganizationTypeId = command.OrganizationTypeId,
                    Region = command.Region,
                    WebSite = command.WebSite,
                    City = command.City,
                    PhoneNumber = command.PhoneNumber,
                    EnglishName = command.EnglishName
                }, Id);
        }
    }
}
