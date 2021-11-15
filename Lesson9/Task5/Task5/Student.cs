using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Student : Person
    {
        public Student(string Name) : base(Name)
        {
            this.Name = Name;
        }

        public void Study()
        {
            Console.WriteLine("studying.");
        }
    }
}
