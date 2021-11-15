using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("gun daxil edin");
            int gun = int.Parse(Console.ReadLine());
            Console.WriteLine("ay daxil edin");
            int ay = int.Parse(Console.ReadLine());
            Console.WriteLine("il daxil edin");
            int il = int.Parse(Console.ReadLine());
            DateTime vaxt = new DateTime(il, ay, gun);

            Console.WriteLine(vaxt.ToString("dd/MM/yyyy"));

            Console.WriteLine("{0} ilin son gunu  : 31/12/{0}", il);
            Console.ReadLine();
        }
    }
}
