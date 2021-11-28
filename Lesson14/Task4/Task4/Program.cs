using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    byte num = byte.Parse(Console.ReadLine());
                    byte result = (byte)(num / 2);
                    if (num % 2 == 0)
                    {
                        Console.WriteLine("This number is couple.");
                    }
                    else
                    {
                        Console.WriteLine("This number is not couple.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter correct format");

                }
                catch (OverflowException)
                {
                    Console.WriteLine("Value was either too large or too small for an unsigned byte!");
                }
            } while (true);

        }
    }
}
