using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.AccountentTrees.Commands;
using Repository.BaseRepositories;
using Data.Entities;
using Data.Access;

namespace Service.AccountentTrees
{
    public class AccountentTreeService
    {
        private readonly IBaseRepository<AccountentTree> _repository;
        private readonly DataContext _context;
        public AccountentTreeService(IBaseRepository<AccountentTree> repository, DataContext context)
        {
            _repository = repository;
            _context = context;
        }
        public void CreateAccountentTree(CreateAccountentTreeCommand command)
        {
            CreateAccountTreeCommandValidator validator = new CreateAccountTreeCommandValidator();
            var result = validator.Validate(command);
            if (!result.IsValid)
            {
                throw new Exception("FluentValidationExeption");
            }
            AccountentTree parent = _repository.GetAll().SingleOrDefault(x => x.Id == command.ParentId);
            if (parent != null)
                command.FullCode = $"{parent.FullCode}-{command.Code}";
            else
                command.FullCode = command.Code;
            _repository.Insert(
                new AccountentTree
                {
                    Code = command.Code,
                    Name = command.Name,
                    ParentId = command.ParentId,
                    FullCode = command.FullCode
                }
                );
        }
        public void DeleteAccountentTree(DeleteAccountentTreeCommand command)
        {
            DeleteAccountentTreeCommandValidator validator = new DeleteAccountentTreeCommandValidator();
            var result = validator.Validate(command);
            if (!result.IsValid)
            {
                throw new Exception("FluentValidationExeption");
            }
            _repository.Delete(command.Id);
        }
        public void UpdateAccountentTree(UpdateAccountentTreeCommand command)
        {
            UpdateAccountentTreeCommandValidator validator = new UpdateAccountentTreeCommandValidator();
            var result = validator.Validate(command);
            if (!result.IsValid)
            {
                throw new Exception("FluentValidationExeption");
            }
            AccountentTree toUpdate = _context.AccountentTrees.SingleOrDefault(x => x.Id == command.ParentId);
            if (toUpdate != null)
            {
                _repository.Update(
                    new AccountentTree
                    {
                        Code = command.Code,
                        Name = command.Name,
                        ParentId = command.ParentId,
                        FullCode = $"{toUpdate.FullCode}-{command.Code}",
                        Id = command.Id
                    },
                    command.Id
                    );
            }
            else
            {
                _repository.Update(
                    new AccountentTree
                    {
                        Code = command.Code,
                        Name = command.Name,
                        ParentId = command.ParentId,
                        FullCode = command.Code,
                        Id = command.Id
                    },
                    command.Id
                    );
            }
        }
    }

}
