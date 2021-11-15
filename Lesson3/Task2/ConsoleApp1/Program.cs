using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1ci ifade");

            string name1 = Console.ReadLine();
            Console.WriteLine("2ci ifade");
            string name2 = Console.ReadLine();
            if (name1.Contains(name2))
            {
                Console.WriteLine("2ci ifade 1in icide var");
            }
            else
            {
                Console.WriteLine("2ci ifade 1in icide yoxdur");
            }
        }
    }
}
