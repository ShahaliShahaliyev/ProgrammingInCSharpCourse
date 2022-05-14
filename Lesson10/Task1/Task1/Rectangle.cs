using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Rectangle : Shape
    {
        protected double side1, side2;

        public new double Area()
        {
            Console.WriteLine("Teref daxil edin");
            double side1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Teref daxil edin");
            double side2 = double.Parse(Console.ReadLine());
            Console.WriteLine("sahe:");
            return side1 * side2;
        }
        public new double Perimeter()
        {
            Console.WriteLine("Teref daxil edin");
            double side1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Teref daxil edin");
            double side2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Perimetr:");
            return 2*(side1 + side2);
        }
    }
}
