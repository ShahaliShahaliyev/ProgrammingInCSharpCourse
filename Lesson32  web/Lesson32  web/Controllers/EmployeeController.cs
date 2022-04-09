using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Lesson32__web.Models;
using System.Linq;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Logging;

namespace Lesson32__web.Controllers
{

    [ApiController]
    [Route("api/controller")]
    public class EmployeeController : Controller
    {

        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(
            ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

        private static List<Employees> _employees = new List<Employees>();
        
        [HttpGet("all")]
        public List<Employees> GetAll()
        {
            _logger.LogInformation("Request accepted {date}",DateTime.Now);

            return _employees;
        }

        [HttpPost("create")]
        public Employees CreateEmployee(Employees employees)
        {
            _logger.LogInformation("Posted {date}",DateTime.Now);

            _employees.Add(employees);
            return employees;
        }

        [HttpPut("update")]
        public Employees UpdateEmployees(int id,Employees newEmployees)
        {

            _logger.LogInformation("Updated{date}", DateTime.Now);


            var employee = _employees.FirstOrDefault(x => x.Id == id);
            employee.Name = newEmployees.Name;
            return newEmployees;
        }

        [HttpDelete("delete")]
        public Employees DeleteEmployees(int id)
        {

            _logger.LogInformation("Deleted {date}", DateTime.Now);


            var employees = _employees.FirstOrDefault(x => x.Id == id);
            _employees.Remove(employees);
            return employees;
        }
    }
}
