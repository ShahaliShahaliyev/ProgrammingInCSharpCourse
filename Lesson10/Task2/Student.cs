using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Student : SchoolPerson
    {
        public new void GoToClasses()
        {
            var result = $"I’m {Name} {Surname}, I am student and I'm going to class.";
            Console.WriteLine(result);
        }
        public new void ShowAge()
        {
            var age = $"My age is 21 years old";
            Console.WriteLine(age);
        }
    }
}
