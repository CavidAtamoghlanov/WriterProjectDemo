using BlogApiDemo.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult EmployeeList()
        {
            using var context = new MyApiContext();
            var employees = context.Employees.ToList();
            return Ok(employees);
        }

        [HttpPost]
        public IActionResult EmployeeAdd(Employee employee)
        {
            using var context = new MyApiContext();
            context.Employees.Add(employee);
            context.SaveChanges();
            return Ok("Employee added successfully");
        }

        [HttpGet("{id}")]
        public IActionResult EmployeeGet(int id)
        {
            using var context = new MyApiContext();
            var employee = context.Employees.FirstOrDefault(x=>x.Id == id);
            if(employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        [HttpDelete("{id}")]
        public IActionResult EmployeeDelete(int id)
        {
            using var context = new MyApiContext();
            var employee = context.Employees.FirstOrDefault(x => x.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            context.Employees.Remove(employee);
            context.SaveChanges();
            return Ok("Employee deleted successfully");
        }


        [HttpPut]
        public IActionResult EmployeeUpdate(Employee employee)
        {
            using var context = new MyApiContext();
            var emp = context.Employees.FirstOrDefault(x => x.Id == employee.Id);
            if (emp == null)
            {
                return NotFound();
            }
            emp.Name = employee.Name;
            context.SaveChanges();
            return Ok("Employee updated successfully");
        }
    }
}
