using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Person
    {


        public string Name { get; set; }

        public Person(string Name)
        {

            this.Name = Name;
        }

        public override string ToString()
        {
            return "Hello! My name is " + Name;
        }
    }
}
