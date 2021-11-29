using System;
using System.Management;
using System.Diagnostics;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ObjectQuery objectQuery = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(objectQuery);
            ManagementObjectCollection results = searcher.Get();

            foreach (ManagementObject result in results)
            {
                Console.WriteLine("Total Visible Memory {0} KB",result["TotalVisibleMemorySize"]);
                Console.WriteLine("Free Physical Memory {0} KB",result["FreePhysicalMemory"]);
                Console.WriteLine("Total Virtual Memory {0} KB", result["TotalVirtualMemorySize"]);
                Console.WriteLine("Free Virtual Memory {0} KB", result["FreeVirtualMemory"]);
            }
        }
    }
}
