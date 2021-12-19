using System;

namespace Task3
{
        public class Program
        {
            static void Main(string[] args)
            {
               Table list = new Table();
            Console.WriteLine(list[0].Name);
            Console.WriteLine(list[1,"Charlie"].Name);
            Console.WriteLine(list[2].Name);
            Console.WriteLine(list[3, "Martin"].Name);
            Console.WriteLine(list[4].Name);
            Console.WriteLine(list[5,"Eve"].Name);
        }
        }
}
