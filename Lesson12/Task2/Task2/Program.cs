using System;
using System.IO;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int counter = 0;

            foreach (string line in System.IO.File.ReadLines(@"C:\Users\Shahali\Documents\Lesson12.txt"));
            {
                counter++;
            }
            Console.WriteLine($"Count line {counter}");
            Console.ReadLine();
            
        }
    }
}
