using Lesson33_36.Data.Entitites;
using Microsoft.EntityFrameworkCore;

namespace Lesson33_36.Data
{
    public class StudentDbContext : DbContext
    {

        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Student>(s =>
            //{
            //    s.HasOne(x => x.Gender).WithMany(x => x.Students).HasForeignKey(x => x.Gender.Id);
            //});
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Gender>().ToTable("Gender");
            modelBuilder.Entity<StudentCourse>().ToTable("StudentCourse");

            modelBuilder.Entity<StudentCourse>().HasKey(x => new {x.StudentId, x.CourseId});

        }
    }
}
