using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name:");
           char[] name = Console.ReadLine().ToCharArray();
            Array.Reverse(name);
            Console.WriteLine(name);
        }
    }
}
