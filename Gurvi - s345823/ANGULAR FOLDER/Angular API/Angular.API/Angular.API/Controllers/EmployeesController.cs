using Angular.API.Data;
using Angular.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Angular.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        private readonly AngularDbContext _angularDbContext;

        public EmployeesController(AngularDbContext angularDbContext)
        {
            _angularDbContext = angularDbContext;
        }

        [HttpGet]

        public async Task<IActionResult> GetAllEmployees()
        {
            var employees = await _angularDbContext.Employees.ToListAsync();
            return Ok(employees);
        }


        [HttpPost]
        public async Task<IActionResult> AddEmployee([FromBody] Employee employeeRequest)
        {
            employeeRequest.Id = Guid.NewGuid();

            await _angularDbContext.Employees.AddAsync(employeeRequest);
            await _angularDbContext.SaveChangesAsync();

            return Ok(employeeRequest);

            [HttpGet]
            [Route("{id:Guid)"}]
        public async Task<IActionResult> GetEmployee([FromRoute] Guid id)
        {
            var employee =
                await _angularDbContext.Employees.FirstOrDefaultAsync(x => x.Id == id);

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }
        [HttpPut]
        [Route("{id:Guid)")]

        public async Task<IActionResult> UpdateEmployee([FromRoute] Guid id, Employees updateEmployeeRequest);
        {
            var employee = await _angularDbContext.Employees.FindAsync(id);
            if (Employee == null)
            {
                return NotFound();
            }
            employee.Name = updateEmployeeRequest.Name;
            employee.Email = updateEmployeeRequest.email;
            employee.Salary = updateEmployeeRequest.Salary;
            employee.Phone = updateEmployeeRequest.Phone;
            employee.Department = updateEmployeeRequest.Department;

            await angularDbContext.SaveChangesAsync();

            Return Ok(employee);


    [HttpDelete]
    [Route("(id:Guid)")]
    public async Task<IActionResult> DeleteEmployee([FromRoute] Guid id)
    {
        var employee = await _angularDbContext.Employees.FindAsync(id);
        if (employee == null)
        {
            return NotFound();
        }
        _angularDbContext.Employees.Remove(Employees);
        await _angularDbContext.SaveChangesAsync();

        return Ok(employee);
    }

            
        }
    }
}
