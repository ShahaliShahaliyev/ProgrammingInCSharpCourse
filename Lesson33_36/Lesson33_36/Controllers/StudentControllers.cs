using Lesson33_36.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson33_36.Data;
using Lesson33_36.Data.Entitites;
using Lesson33_36.Repository;
using Microsoft.EntityFrameworkCore;

namespace Lesson33_36.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentControllers : ControllerBase
    {
        private  readonly StudentDbContext _studentDbContext;
        private readonly  IStudentManagerRepository _studentManagerRepository;

        public StudentControllers(
            StudentDbContext studentDbContext,
            IStudentManagerRepository studentManagerRepository)
          
        {
            _studentDbContext = studentDbContext;
            _studentManagerRepository = studentManagerRepository;
        }

        private static List<Student> _students = new List<Student>();

        [HttpGet("all")]
        public async Task<object> GetAll()
        {
            var query = from sc in _studentDbContext.StudentCourses
                        join s in _studentDbContext.Students on sc.StudentId equals s.Id
                        join c in _studentDbContext.Courses on sc.CourseId equals c.Id
                        join g in _studentDbContext.Genders on sc.CourseId equals g.Id
                        select new
                        {
                            s.Name,
                            s.Surname,
                            s.DateOfBirth,
                            GenderName = g.Name,
                            CourseName = c.Name,
                            sc.StartDate,
                            sc.EndDate
                        };
            return await query.ToListAsync();
        }

        [HttpGet("student/{id}")]
        public async Task<IActionResult> GetStudent(int id)
        {
            var  student = await _studentDbContext.Students.FirstOrDefaultAsync(s => s.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }


        [HttpPost("create")]
        public async Task<IActionResult> CreateStudent(Student student)
        {
            await _studentDbContext.AddAsync(student);
            await _studentDbContext.SaveChangesAsync();
            return Created($"/api/student/student/{student.Id}", student);
        }

        [HttpPut("update")]
        public async Task<Student> UpdateStudent(int id, Student newStudent)
        {
            var student = await _studentDbContext.Students.FirstOrDefaultAsync(s => s.Id == id);
            student.Name = newStudent.Name;
            student.Surname = newStudent.Surname;
            student.Salary = newStudent.Salary;

            return newStudent;
        }

        [HttpDelete("delete")]
        public async Task<Student> DeleteStudent(int id)
        {
            var student = await _studentDbContext.Students.FirstOrDefaultAsync(s => s.Id == id);
            _studentDbContext.Students.Remove(student);
            await _studentDbContext.SaveChangesAsync();

            return student;
        }
    }
}
