using System;

namespace Task5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("Juan");
            teacher.Explain();                                                          

            Student student = new Student("Sara");
            student.Study();

            Student student1 = new Student("Carlos");
            student1.Study();



        }
    }
}
