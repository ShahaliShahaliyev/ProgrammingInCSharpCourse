using System;
using System.IO;
using System.Threading;

namespace Exam1Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                if (File.Exists(@"C:\Users\Shahali\Downloads\Lesson16\Student.txt"))
                {
                    Console.WriteLine(File.ReadAllText(@"C:\Users\Shahali\Downloads\Lesson16\Student.txt"));
                }
                else
                {
                    Console.WriteLine("There is no new record!");
                }
                Thread.Sleep(10000);

            } while (true);

        }
    }
}
