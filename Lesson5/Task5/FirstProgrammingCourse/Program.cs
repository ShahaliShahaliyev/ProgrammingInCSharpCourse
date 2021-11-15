using System;

namespace FirstProgrammingCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("reqem daxil et:");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
