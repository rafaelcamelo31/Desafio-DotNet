using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Controllers
{
    [Route("employees")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly NorthwindContext _context;

        public EmployeeController(NorthwindContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Employee> GetEmployees()
        {
            return _context.Employees
            .Include(e => e.Orders);
        }

    }
}