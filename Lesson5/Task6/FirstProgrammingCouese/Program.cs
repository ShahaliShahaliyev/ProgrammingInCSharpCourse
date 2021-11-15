using System;

namespace FirstProgrammingCouese
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 1;
            
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}",k++);
                }
                
                Console.WriteLine();
            }
        }
    }
}
