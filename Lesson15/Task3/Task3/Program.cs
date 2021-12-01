using System;
using System.Collections.Generic;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, int> person = new Dictionary<String, int>();
            person.Add("Shahali", 17);
            person.Add("Ahmed", 35);

            //person.Remove("Ahmed");
            //foreach (var item in person)
            //{
            //    Console.WriteLine($"{item.Key},{item.Value}");
            //}

            var firstPerson =person.GetEnumerator();
            firstPerson.MoveNext();
            var currentPerson =firstPerson.Current;

            Console.WriteLine($"{currentPerson.Key},{currentPerson.Value}");
            
        }

        

      
    }
}
