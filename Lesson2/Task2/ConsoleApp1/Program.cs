﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ad daxil edin\n");
            string name = Console.ReadLine();
            Console.WriteLine(name.ToUpper());
            Console.Write("soyad daxil edin\n");
            string surname = Console.ReadLine();
            Console.WriteLine(surname.ToUpper());
        }
    }
}
