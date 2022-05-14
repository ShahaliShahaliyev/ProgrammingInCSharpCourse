using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Task1
{
    public class Circle : Shape
    {
        protected double radius;
        
        public Circle()
        {
            Console.WriteLine("Radiusu daxil edin");
            double radius = double.Parse(Console.ReadLine());

            this.radius = radius;
        }

        public  new  double Area()
        {

            Console.WriteLine("Sahe:");
            return radius*radius*Math.PI;
        }

        public new double Perimeter()
        {
            Console.WriteLine("Perimetr:");
            return Math.PI * radius * 2;
        }
    }
}
