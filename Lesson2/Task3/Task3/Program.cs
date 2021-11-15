using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("radiusu daxil et");
            double radius = float.Parse(Console.ReadLine());

            double perimetr = 2 * Math.PI * radius;
            Console.WriteLine("perimetr : " + perimetr);

            double sahe = Math.PI * radius * radius;
            Console.WriteLine("sahe : " + sahe);
        }
    }
}
