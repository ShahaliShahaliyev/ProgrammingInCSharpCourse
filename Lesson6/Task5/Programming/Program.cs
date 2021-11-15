using System;

namespace Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("eded daxil edin");
            int number = int.Parse(Console.ReadLine());
            GetFibonacciSeries(number);
        }
        private static void GetFibonacciSeries(int number)
        {
            int number1 = 0;
            int number2 = 1;
            int number3;
            Console.Write("0 1  ");

            for (int i = 0; i < number; i++)
            {
                number3 = number1 + number2;
                number1 = number2;
                number2 = number3;
                Console.Write(number3 + " ");
            }
            Console.WriteLine();
        }
    }
}
