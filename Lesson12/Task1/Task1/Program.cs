using System;
using System.IO;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Shahali\Downloads\Lesson12";

            string[] directories = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);
            foreach (var directory in directories)
            {
                Directory.Delete(directory);
            }
            foreach (var file in files)
            {
                switch (Path.GetExtension(file))
                {
                    case ".txt":
                        File.Move(file, @"C:\Users\Shahali\Downloads\Lesson12\text", true);
                        break;
                    case ".mp4":
                        File.Move(file, @"C:\Users\Shahali\Downloads\Lesson12\video", true);
                        break;
                    case ".mp3":
                        File.Move(file, @"C:\Users\Shahali\Downloads\Lesson12\music", true);
                        break;
                    default:
                        File.Move(file, @"C:\Users\Shahali\Downloads\Lesson12\other", true);
                        break;

                }
            }
        }
    }
}
