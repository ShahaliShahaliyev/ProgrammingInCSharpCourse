using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name:");
            var name = Console.ReadLine();
           
            Console.WriteLine("Enter surname:");
            var surname = Console.ReadLine();

            Console.WriteLine(name.ToUpper()+" " + surname.ToUpper());
        }
    }
}
