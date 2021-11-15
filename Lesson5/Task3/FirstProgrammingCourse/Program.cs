using System;

namespace FirstProgrammingCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());
            int number5 = int.Parse(Console.ReadLine());
            float sum = number1 + number2 + number3 + number4 + number5;
            Console.WriteLine("sum = " + sum);
            Console.WriteLine("average = " + sum / 5);
            Console.WriteLine();

        }
    }
}
