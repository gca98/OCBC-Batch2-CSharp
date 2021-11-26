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

        [HttpPost]
        public async Task<IActionResult> CreateEmployee([FromBody] EmployeeItem dataemployee)
        {
            if (ModelState.IsValid)
            {
                _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
                _context.InsertEmployee(dataemployee);
                return new JsonResult("Insert" + dataemployee);
            }
            else
            {
                return new JsonResult("");
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> EditEmployee(int id, [FromBody] EmployeeItem dataemployee)
        {
            if (ModelState.IsValid)
            {
                _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
                _context.UpdateEmployee(id, dataemployee);
                return new JsonResult("Update Data" + dataemployee);
            }
            else
            {
                return new JsonResult("");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> HapusEmployee(int id)
        {
            if (ModelState.IsValid)
            {
                _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
                _context.DeleteEmployee(id);
                return new JsonResult("Delete Data");
            }
            else
            {
                return new JsonResult("");
            }
        }

    }
}
