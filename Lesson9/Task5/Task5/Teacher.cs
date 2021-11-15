using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Teacher : Person
    {
        public Teacher(string Name) : base(Name)
        {
            this.Name = Name;
        }

        public void Explain()
        {
            Console.WriteLine("explaining.");
        }
    }
}
