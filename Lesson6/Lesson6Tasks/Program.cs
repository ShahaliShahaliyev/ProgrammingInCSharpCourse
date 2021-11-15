using System;

namespace Lesson6Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10 100 arasi eded daxil edin:");
            int number = int.Parse(Console.ReadLine());

            Random random = new();

            int[] numbers = new int[number];

            for (int i = 0; i < number; i++)
            {
                numbers[i] = random.Next(1, 100);
                Console.WriteLine("eded" + i + " = " + numbers[i]);
            }

            Array.Sort(numbers);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Array.Reverse(numbers);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine(numbers[2]);
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
