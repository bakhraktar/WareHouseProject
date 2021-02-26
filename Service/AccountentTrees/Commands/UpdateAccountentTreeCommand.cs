using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Service.AccountentTrees.Commands
{
    public class UpdateAccountentTreeCommand
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
    }
    public class UpdateAccountentTreeCommandValidator : AbstractValidator<UpdateAccountentTreeCommand>
    {
        public UpdateAccountentTreeCommandValidator()
        {

        }
    }
}
