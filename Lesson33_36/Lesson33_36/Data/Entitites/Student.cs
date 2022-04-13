using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lesson33_36.Data.Entitites
{
    public class Student
    {
            [Key]
            public int Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public DateTime DateOfBirth { get; set; }
            public int? Salary { get; set; }
            public int? GenderId { get; set; }

            public  Gender Gender { get; set; }
            public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
