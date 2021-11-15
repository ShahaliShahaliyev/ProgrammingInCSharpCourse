using System;

namespace FirstProgrammingCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dogum tarixinizi yazin");
            DateTime date1 = Convert.ToDateTime(Console.ReadLine());

            DateTime date2 = DateTime.Now;
            TimeSpan date3 = date2 - date1;

            Console.WriteLine(date3);
            Console.ReadLine();
        }
    }
}
