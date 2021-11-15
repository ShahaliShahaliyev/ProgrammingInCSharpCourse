using System;

namespace FirstProgrammingCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
                sum += i;
            }

            Console.WriteLine("sum is"+(sum));
            
            Console.WriteLine();
        }
    }
}
