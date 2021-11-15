using System;

namespace Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("eded daxil edin:");
            int  eded = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (eded != 0)
            {
                sum += eded % 10;
                eded /= 10;
            }
            Console.WriteLine("reqemlerin cemi="+sum);
        }
    }
}
