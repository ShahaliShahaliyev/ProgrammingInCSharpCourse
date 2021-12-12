using System;
using System.IO;

namespace Exam2Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Shahali\Downloads\Lesson16\Student.txt";

            do
            {
                Student student = new Student();
                Console.WriteLine("Name:");
                student.Name = Console.ReadLine();

                Console.WriteLine("Surname:");
                student.Surname = Console.ReadLine();

                Console.WriteLine("Date of Birth:");
                student.DateOfBirth = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("ID:");
                student.ID = int.Parse(Console.ReadLine());

                Console.WriteLine(student.PrintStudent());
                Console.WriteLine("Already all done!");
                Console.WriteLine("-----");

                var print = student.PrintStudent();
                File.AppendAllText(path, print);


                Console.WriteLine("Do you want to continue?\nTo continue:yes\nTo stop:no");
                var end = Console.ReadLine();

                if (end == "no")
                {

                    break;
                }

            } while (true);



        }
    }
}
