using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using Repository.Base;

namespace Repository.EmployeeRepositories
{
    public interface IEmployeeRepository : IBaseRepository<Employee>
    {
        Employee 
    }
}
