using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class SchoolPerson
    {
        public string SchoolName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public DateTime DateofBirth { get; set; }
        public int CurrentClass { get; set; }
        public int ShowAge { get; set; }
        public void Greet()
        {
            var str = $"Hello {Name} {Surname}";
            Console.WriteLine(str);
        }
        public void GoToClasses()
        {

        }
    }
}
