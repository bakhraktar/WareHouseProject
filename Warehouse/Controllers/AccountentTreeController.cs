using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Repository.BaseRepositories;
using Data.Entities;
using Service.AccountentTrees.Commands;
using Service.AccountentTrees;
using Data.Access;

namespace Warehouse.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountentTreeController : ControllerBase
    {
        private readonly IBaseRepository<AccountentTree> _repository;
        private readonly AccountentTreeService _service;
        private readonly DataContext _context;
        public AccountentTreeController(IBaseRepository<AccountentTree> repository, AccountentTreeService service, DataContext context)
        {
            _repository = repository;
            _service = service;
            _context = context;
        }
        [HttpGet("GetAll")]
        public ActionResult GetAll()
        {
            if(_context.Set<AccountentTree>().Count() == 0)
            {
                return NotFound("Table is Empty");
            }
            return Ok(_repository.GetAll());
        }
        [HttpGet("GetById")]
        public ActionResult GetById(int Id)
        {
            var toReturn = _repository.GetById(Id);
            if (toReturn == null)
            {
                return NotFound("Didn't find");
            }
            return Ok(toReturn);
        }
        [HttpPost("Create")]
        public ActionResult Create(CreateAccountentTreeCommand command)
        {
            _service.CreateAccountentTree(command);
            return Ok(command);
        }
        [HttpDelete("Delete")]
        public ActionResult Delete(DeleteAccountentTreeCommand command)
        {
            var tmp = _repository.GetById(command.Id);
            if (tmp == null)
            {
                return NotFound("Didn't find");
            }
            _service.DeleteAccountentTree(command);
            return Ok(command);
        }
        [HttpPut("Update")]
        public ActionResult Update(UpdateAccountentTreeCommand command)
        {
            _service.UpdateAccountentTree(command);
            return Ok(command);
        }
    }
}
