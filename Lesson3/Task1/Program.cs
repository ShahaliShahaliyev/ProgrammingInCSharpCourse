using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir eded daxil edin : ");

            int eded = Convert.ToInt32(Console.ReadLine());

            if (eded % 2 == 0)
            {
                Console.WriteLine("Bu eded cut ededdir.");
            }
            else
            {
                Console.WriteLine("Bu eded tek ededdir.");
            }
        }
    }
}
