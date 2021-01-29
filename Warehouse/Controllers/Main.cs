using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Entities;
using Data.Access;

namespace Warehouse.Controllers
{
    [ApiController]
    [Route("WareHouse/[Controller]")]
    public class Main : Controller
    {
        private readonly DataContext _DataContext;
        public Main(DataContext DataContext)
        {
            _DataContext = DataContext;
        }

        [Route("GetAllProducts")]
        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            return _DataContext.Products;
        }
    }
}
