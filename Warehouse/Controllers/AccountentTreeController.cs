using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Repository.BaseRepositories;
using Data.Entities;

namespace Warehouse.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountentTreeController : ControllerBase
    {
        private readonly IBaseRepository<AccountentTree> _repository;
        public AccountentTreeController(IBaseRepository<AccountentTree> repository)
        {
            _repository = repository;
        }
        [HttpGet("GetAll")]
        public IEnumerable<AccountentTree> GetAll()
        {
            return _repository.GetAll();
        }
        [HttpGet("{Id}")]
        public ActionResult GetById(int Id)
        {
            return Ok(_repository.GetById(Id));
        }
    }
}
