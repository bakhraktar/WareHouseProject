using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Service.AccountentTrees.Commands
{
    public class DeleteAccountentTreeCommand
    {
        public int Id { get; set; }
    }
    public class DeleteAccountentTreeCommandValidator : AbstractValidator<DeleteAccountentTreeCommand>
    {
        public DeleteAccountentTreeCommandValidator()
        {

        }
    }
}
