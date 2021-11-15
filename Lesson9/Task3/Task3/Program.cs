using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        public static void Main()
        {
            Person person = new Person();
            person.Greet();

            Student student = new Student();    
            student.SetAge(17);
            student.Greet();
            student.ShowAge();
            
            Professor professor = new Professor();
            professor.SetAge(40);
            professor.Greet();  
            professor.Explain();
        }
    }
}
