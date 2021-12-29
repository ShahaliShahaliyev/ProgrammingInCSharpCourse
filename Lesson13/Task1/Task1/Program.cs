using System;
using System.IO;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfDick = 0;
            foreach (DriveInfo driveinfo in DriveInfo.GetDrives())
            {
                if (driveinfo.DriveType ==DriveType.Fixed)
                {
                    countOfDick++;
                    Console.WriteLine($"Drive name: {driveinfo.Name}");
                    Console.WriteLine($"Total size: {driveinfo.TotalSize/ 1048576}  MB");
                    Console.WriteLine($"Avaliable size: {driveinfo.AvailableFreeSpace/ 1048576} MB");
                    Console.WriteLine($"Used size:{driveinfo.TotalSize - driveinfo.TotalFreeSpace/ 1048576} MB" );
                }

            }
            Console.ReadLine();
        }
    }
}
