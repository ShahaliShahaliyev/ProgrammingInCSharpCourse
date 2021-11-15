using System;

namespace FirstProgrammingCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tarix daxil et dd:MM:yyyy");
            int date1 = int.Parse(Console.ReadLine());
            int date2 = int.Parse(Console.ReadLine());
            int date3 = int.Parse(Console.ReadLine());
            if ((date1<31) &&
                (date2<12))

            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            Console.WriteLine();
        }
    }
}
