using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Lesson32__web.Models;
using System.Linq;

namespace Lesson32__web.Controllers
{
    [ApiController]
    [Route("api/controller")]
    public class EmployeeController : Controller
    {
        private static List<Employees> _employees = new List<Employees>();
        
        [HttpGet("all")]
        public List<Employees> GetAll()
        {
            return _employees;
        }

        [HttpPost("create")]
        public Employees CreateEmployee(Employees employees)
        {
            _employees.Add(employees);
            return employees;
        }

        [HttpPut("update")]
        public Employees UpdateEmployees(int id,Employees newEmployees)
        {
            var employee = _employees.FirstOrDefault(x => x.Id == id);
            employee.Name = newEmployees.Name;
            return newEmployees;
        }

        [HttpDelete("delete")]
        public Employees DeleteEmployees(int id)
        {
            var employees = _employees.FirstOrDefault(x => x.Id == id);
            _employees.Remove(employees);
            return employees;
        }
    }
}
