using System;
using System.IO;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Shahali\Downloads\Lesson12";
            const string pictures = @"C:\Users\Shahali\Downloads\Lesson12\Image";
            const string videos = @"C:\Users\Shahali\Downloads\Lesson12\Video";
            const string text = @"C:\Users\Shahali\Downloads\Lesson12\Text";
            const string music = @"C:\Users\Shahali\Downloads\Lesson12\Music";
            const string office = @"C:\Users\Shahali\Downloads\Lesson12\Office";
            const string others = @"C:\Users\Shahali\Downloads\Lesson12\Other";


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
                    case ".jpg":
                    case ".jpeg":
                    case ".img":
                    case ".png":
                        {
                            File.Move(file, pictures);
                        }
                        break;
                    case ".mp4":
                        {
                            File.Move (file, videos);
                        }
                        break;
                    case ".txt":
                    case ".doc":
                    case ".docx":
                    case ".faq":
                        {
                            File.Move(file, text);
                        }
                        break;
                    case ".mp3":
                        {
                            File.Move(file, music);
                        }
                        break;
                    case ".pptx":
                    case ".pdf":
                    case ".xps":
                    case ".xml":
                    case ".":
                        {
                            File.Move(file, office);
                        }
                        break ;
                    default:
                        {
                            File.Move(file, others);
                        }
                            break;
                }
            }
        }
    }
}
