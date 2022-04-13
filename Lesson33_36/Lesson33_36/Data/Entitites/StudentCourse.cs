using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson33_36.Data.Entitites
{
    public class StudentCourse
    {
        [ForeignKey(nameof(StudentId))]
        public int StudentId { get; set; }
        
        [ForeignKey(nameof(CourseId))]
        public int CourseId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public Course Course { get; set; }
        public  Student Student { get; set; }
    }
}