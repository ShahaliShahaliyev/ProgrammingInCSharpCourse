using System;
using System.Diagnostics;
using System.Threading;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total", true);
            var value = cpuCounter.NextValue();
            
            if (Math.Abs(value) <= 0.00)
                value = cpuCounter.NextValue();

            Console.WriteLine($"CPU: {value}%");
        }

        
    }
}
