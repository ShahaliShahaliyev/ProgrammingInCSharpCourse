using System;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            var area = circle.Area();
            Console.WriteLine(area);
            var perimeter = circle.Perimeter();
            Console.WriteLine(perimeter);

            Rectangle rectangle=new Rectangle();
            var area1 = rectangle.Area();
            Console.WriteLine(area1);
            var perimeter1 = rectangle.Perimeter();
            Console.WriteLine(perimeter1);
            
        }
    }
}
