using System;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int n = int.Parse(Console.ReadLine());
            int t = 9;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(t + " ");
                sum = sum + t;
                t = (t * 10) + 9;
            }
            Console.Write("\nThe Sum is : {0}\n", sum);
        }
    }
}
