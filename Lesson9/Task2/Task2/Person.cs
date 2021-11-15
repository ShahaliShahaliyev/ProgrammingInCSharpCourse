using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Person
    {
        public string Name;
        public Person(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return "Hello!My name is "+ Name;
        }
        ~Person()
        {
            Name = "";
        }
    }
}
