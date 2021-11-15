using System;

namespace Task2
{
    public class Program
    {
        public static void Main()
        {
            SchoolPerson student = new SchoolPerson();
            student.Name = "Shahali";
            student.Surname = "Shahaliyev";
            student.Greet();
            Console.WriteLine(" ");
            Student student1 = new Student();
            student1.Name = "Shahali";
            student1.Surname = "Shahaliyev";
            student1.Greet();
            student1.GoToClasses();
            student1.ShowAge();
            Console.WriteLine(" ");
            Teacher teacher = new Teacher();
            teacher.Name = "Nurlan";
            teacher.Surname = "Valizada";
            teacher.subject = "C#";
            teacher.Greet();
            teacher.GoToClasses();
            teacher.Explain();
            teacher.ShowAge();
        }
    }
    public class SchoolPerson
    {
        public string SchoolName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public DateTime DateofBirth { get; set; }
        public int CurrentClass { get; set; }
        public int ShowAge { get; set; }
        public void Greet()
        {
            var str = $"Hello {Name} {Surname}";
            Console.WriteLine(str);
        }
        public void GoToClasses()
        {

        }

    }
    public class Student : SchoolPerson
    {
        public new void GoToClasses()
        {
            var result = $"I’m {Name} {Surname}, I am student and I'm going to class.";
            Console.WriteLine(result);
        }
        public new void ShowAge()
        {
            var age = $"My age is 21 years old";
            Console.WriteLine(age);
        }
    }
    public class Teacher : SchoolPerson
    {
        public string subject;
        public void Explain()
        {

            var result = $"Explanation begin on  {subject}";
            Console.WriteLine(result);
        }
        public new void GoToClasses()
        {
            var result = $"I’m {Name} {Surname}, I am a teacher.";
            Console.WriteLine(result);
        }
        public new void ShowAge()
        {
            var result = $"My age is 30 years old";
            Console.WriteLine(result);
        }
    }
}
