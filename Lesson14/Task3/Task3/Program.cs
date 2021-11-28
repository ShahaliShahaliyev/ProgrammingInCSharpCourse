using System;


namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 =0, num2 =0;

            try
            {
                Console.WriteLine("Enter first number:");
                num1=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                num2 = Convert.ToDouble(Console.ReadLine());

            }
            catch (FormatException)
            {
                Console.WriteLine("Enter correct format.");
                
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Enter correct numeral.");

            }
        }
    }
}
