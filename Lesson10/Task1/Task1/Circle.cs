using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Circle : Shape
    {
        protected double radius;
        
        public Circle(double radius = 5)
        {
            this.radius = radius;
        }

        public  new  double Area()
        {
            return radius*radius*Math.PI;
        }

        public new double Perimeter()
        {
            return Math.PI * radius * 2;
        }
    }
}
