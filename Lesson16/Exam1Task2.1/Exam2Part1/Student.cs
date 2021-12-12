using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2Part1
{
    internal class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string PrintStudent()
        {
            var info = $"Name:{Name} Surname:{Surname} Date of brith:{DateOfBirth.ToString("dd.MM.yyyy")} ID:{ID}\n";
            return info;
        }
    }

   
}
