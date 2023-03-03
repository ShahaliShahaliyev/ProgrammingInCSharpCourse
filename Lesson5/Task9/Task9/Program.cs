using System;

namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, flg1 = 1, flg2 = 1, flg3 = 0, j;
          
            Console.Write("\n\n");


            Console.Write("Input  a positive integer: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 3; i <= n / 2; i++)
            {
                flg1 = 1;
                flg2 = 1;
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    { flg1 = 0; j = i; }
                }
                for (j = 2; j < n - i; j++)
                {
                    if ((n - i) % j == 0)
                    { flg2 = 0; j = n - i; }
                }
                if (flg1 == 1 && flg2 == 1)
                {
                    Console.Write("{0} =  {1} + {2}  \n", n, i, n - i);
                    flg3 = 1;
                }
            }
            if (flg3 == 0)
            { Console.Write("\n{0} can not be expressed as sum of two prime numbers.\n\n", n); }
        }
    }
}
