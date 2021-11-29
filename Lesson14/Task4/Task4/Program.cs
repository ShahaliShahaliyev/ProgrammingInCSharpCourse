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
                    int num = int.Parse(Console.ReadLine());
                    int result = (int)(num / 2);
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
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            } while (true);

        }
    }
}
