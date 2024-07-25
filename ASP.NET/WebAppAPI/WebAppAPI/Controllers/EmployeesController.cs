using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppAPI.Data;
using WebAppAPI.Model;
using WebAppAPI.Model.Entities;
namespace WebAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public EmployeesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var employees = dbContext.Employees.ToList();
            return Ok(employees);
        }
        [HttpPost]
        public IActionResult AddEmployee(AddEmployeeDto addEmployee)
        {
            var employeeEntity = new Employee()
            {
                Name = addEmployee.Name,
                Email = addEmployee.Email,
                Phone = addEmployee.Phone,
                Salary = addEmployee.Salary
            };
            dbContext.Employees.Add(employeeEntity);
            dbContext.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);

            
        }
    }
}
