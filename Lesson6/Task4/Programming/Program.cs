using System;

namespace Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1ci ededi daxil edin:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("2ci ededi daxil edin:");
            int b = int.Parse(Console.ReadLine());

            result(a, b);
        }

        static void result(int a, int b)
        {
            Console.WriteLine("1ci eded=" + b);

            Console.WriteLine("2ci eded=" + a);
        }
    }
}
