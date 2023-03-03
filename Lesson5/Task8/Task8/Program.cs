using System;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int number = int.Parse(Console.ReadLine());
            for (int j = 1; j <= number; j++)
            {
                num = 0;
                for (int i = 2; i <= j / 2; i++)
                {
                    Console.WriteLine(i);
                    if (j % i == 0)
                    {
                        num++;
                        break;
                    }
                }

                if (num == 0 && j != 1)
                    Console.Write("{0} ", j);
            }
            Console.Write("\n");
        }
    }
}
