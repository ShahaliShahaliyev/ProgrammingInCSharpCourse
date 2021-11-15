using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[3];
            for (int i = 0; i < 3; i++)
            {
               person[i] = new Person(Console.ReadLine());
            }
            for (int i = 0;i < 3; i++)
            {
                Console.WriteLine(person[i].ToString());
            }
        }
    }
}
