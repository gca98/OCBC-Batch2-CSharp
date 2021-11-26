using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kantor_WebAPI.Models;
using Microsoft.AspNetCore.Http;

namespace Kantor_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class EmployeeController : ControllerBase
    {
        private EmployeeContext _context;
        public EmployeeController(EmployeeContext context)
        {
            this._context = context;
        }
        [HttpGet(Name = "Get All")]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItems()
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.GetAllEmployee();
        }

        [HttpGet("{id}", Name = "Get Where")]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItem(string id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.GetEmployee(id);
        }
    }
}
