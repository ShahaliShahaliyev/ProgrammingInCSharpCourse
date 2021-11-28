using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1, num2;
            byte result;


            try
            {
                num1 = 30;
                num2 = 60;
                result = Convert.ToByte(num1 * num2);
                Console.WriteLine("{0} x {1} = {2}", num1, num2, result);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Value was either too large or too small for an unsigned byte!");
               
            }

            Console.ReadLine();
        }
    }
}
