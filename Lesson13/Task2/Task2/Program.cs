using System;
using System.IO;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counOfRam = 0;
            foreach ( DriveInfo ramInfo in DriveInfo.GetDrives())
            {
                if (ramInfo.DriveType == DriveType.Fixed)
                {
                    counOfRam++;
                    Console.WriteLine($"Size of RAM:{ramInfo.TotalSize/ 1073741824} GB");
                    Console.WriteLine($"Current storage:{ramInfo.TotalSize - ramInfo.TotalFreeSpace/ 1073741824} GB");

                }
            }   
        }
    }
}
