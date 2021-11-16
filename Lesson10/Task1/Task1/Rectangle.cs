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

        public new double Area(double side1=5 , double side2  =6)
        {
            return side1 * side2;
        }
        public new double Perimeter(double side1 = 5, double side2 = 6)
        {
            return 2*(side1 + side2);
        }
    }
}
