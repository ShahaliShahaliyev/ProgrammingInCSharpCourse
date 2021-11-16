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
    
}
