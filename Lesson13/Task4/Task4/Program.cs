using System;
using System.Diagnostics;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var process = new ProcessStartInfo("shutdown","/s /t 0");
            process.UseShellExecute = false;
            process.RedirectStandardOutput = true;
            Process.Start(process);
        }
    }

}
