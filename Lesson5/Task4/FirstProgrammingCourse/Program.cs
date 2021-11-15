using System;

namespace FirstProgrammingCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=10 ; i++)
            {
                    Console.WriteLine("{0} X {1} = {2}", i, n, i * n);
            }
            Console.WriteLine();
        }
    }
}
