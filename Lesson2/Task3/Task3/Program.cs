using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius:");
             double radius = double.Parse(Console.ReadLine());

            double perimeter = radius * Math.PI * 2; 

            double area = radius* radius* Math.PI;

            Console.WriteLine($"Perimeter:{perimeter}\n Area:{area}");
        }
    }
}
