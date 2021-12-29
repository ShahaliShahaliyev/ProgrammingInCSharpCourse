﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Nationality { get; set; }
        public string? Gender { get; set; }
        public string? Adress { get; set; }

        public string StudentProperties()
        {
            var result = $"ID:{Id},Name:{Name},Surname:{Surname}," +
                $"DateOfBirth:{DateOfBirth:dd.MM.yyyy},Nationality:{Nationality},Gender:{Gender},Adress:{Adress}\n";

            return result;
        }
    }
}