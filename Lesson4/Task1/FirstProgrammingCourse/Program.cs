using System;

namespace FirstProgrammingCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dogum tarixinizi daxil edin");
            DateTime tarix = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine(tarix.DayOfWeek);
        }
    }
}
