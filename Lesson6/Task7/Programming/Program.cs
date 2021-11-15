using System;

namespace Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            var cumle = Console.ReadLine();
            BosluqSayi(cumle);
        }
        static void BosluqSayi(string cumle)
        {
            char[] cumleArray = cumle.ToCharArray();
            int say = 0;
            for (int i = 0; i < cumleArray.Length; i++)
            {
                if (cumleArray[i] == ' ')
                {
                    say++;
                }
            }
            Console.WriteLine("Bosluq sayi:"+say);
        }
    }
}
