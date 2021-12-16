using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            float var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            float var2 = Convert.ToInt32(Console.ReadLine());
            float netice = var1 / var2;
            Console.WriteLine($"Result:{netice}");

        }
    }
}
