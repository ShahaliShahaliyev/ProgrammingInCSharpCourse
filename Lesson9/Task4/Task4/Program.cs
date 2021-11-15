using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           PhotoBook photoBook = new PhotoBook();
            Console.WriteLine(photoBook.NumPages);
            PhotoBook photoBook1 = new PhotoBook(24);
            Console.WriteLine(photoBook1.NumPages);
            BigPhotoBook bigPhotoBook1 = new BigPhotoBook();
            Console.WriteLine(bigPhotoBook1.NumPages);
        }
    }
}
