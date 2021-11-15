using System;

namespace FirstProgrammingCourse

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("soz elave edin.");

            char[] name = Console.ReadLine().ToCharArray();
            Array.Reverse(name);
            Console.WriteLine(name);
        }
    }
}
