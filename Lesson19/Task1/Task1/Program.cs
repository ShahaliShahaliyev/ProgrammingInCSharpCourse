using System;
using System.Linq;
using System.Threading;


namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread method1 = new Thread(() => Method1(12));
            method1.Start();

            Thread method2 = new Thread(() => Method2(12));
           method2.Start();

        static void Method1(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Method1-{i}");
                Thread.Sleep(500);
            }

        }
        static void Method2(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Method2-{i}");
                Thread.Sleep(500);
            }
        }
    }
}
