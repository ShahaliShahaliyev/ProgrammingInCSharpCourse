using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson33_36.Data.Entitites
{
    [Table("Course")]
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime? CreationDateTime { get; set; }

        public System.Collections.Generic.ICollection<StudentCourse> StudentsCourses { get; set; }
    }
}