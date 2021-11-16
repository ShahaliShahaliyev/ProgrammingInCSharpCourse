using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Teacher : SchoolPerson
    {
        public string subject;
        public void Explain()
        {

            var result = $"Explanation begin on  {subject}";
            Console.WriteLine(result);
        }
        public new void GoToClasses()
        {
            var result = $"I’m {Name} {Surname}, I am a teacher.";
            Console.WriteLine(result);
        }
        public new void ShowAge()
        {
            var result = $"My age is 30 years old";
            Console.WriteLine(result);
        }
    }
}
