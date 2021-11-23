using System;
using System.IO;


namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\Shahali\Downloads");
            FileInfo[] files = directoryInfo.GetFiles("*",SearchOption.AllDirectories);
            Console.WriteLine("Count is:"+files.Length.ToString());
           
        }
    }
}
