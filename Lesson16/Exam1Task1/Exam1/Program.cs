using System;
using System.Collections.Generic;

namespace Exam1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ali = new Person();
            ali.ID = 1;
            ali.Name = "Ali";
            ali.Surname = "Shahaliyev";
            ali.DateOfBirth = DateTime.Now.AddYears(-100);
            ali.Children = null;

            var abbas = new Person();
            abbas.ID = 2;
            abbas.Name = "Abbas";
            abbas.Surname = "Shahaliyev";
            abbas.DateOfBirth = DateTime.Now.AddYears(-80);
            abbas.Parent = ali;

            var ahmed = new Person();
            ahmed.ID = 3;
            ahmed.Name = "Ahmed";
            ahmed.Surname = "Shahaliyev";
            ahmed.DateOfBirth = (DateTime)DateTime.Now.AddYears(-79);
            ahmed.Parent = ali;

            var mamed = new Person();
            mamed.ID = 4;
            mamed.Name = "Mamed";
            mamed.Surname = "Shahaliyev";
            mamed.DateOfBirth = DateTime.Now.AddYears(-60);
            mamed.Parent = abbas;

            var mustafa = new Person();
            mustafa.ID = 5;
            mustafa.Name = "Mustafa";
            mustafa.Surname = "Shahaliyev";
            mustafa.DateOfBirth = DateTime.Now.AddYears(-59);
            mustafa.Parent = abbas;

            var arif = new Person();
            arif.ID = 6;
            arif.Name = "Arif";
            arif.Surname = "Shahaliyev";
            arif.DateOfBirth = DateTime.Now.AddYears(-40);
            arif.Parent = mamed;

            var resad = new Person();
            resad.ID = 7;
            resad.Name = "Resad";
            resad.Surname = "Shahaliyev";
            resad.DateOfBirth = DateTime.Now.AddYears(-39);
            resad.Parent = mamed;

            var revan = new Person();
            revan.ID = 8;
            revan.Name = "Revan";
            revan.Surname = "Shahaliyev";
            revan.DateOfBirth = DateTime.Now.AddYears(-38);
            revan.Parent = mustafa;

            var rauf = new Person();
            rauf.ID = 9;
            rauf.Name = "Rauf";
            rauf.Surname = "Shahaliyev";
            rauf.DateOfBirth = DateTime.Now.AddYears(-20);
            rauf.Parent = arif;

            var nihad = new Person();
            nihad.ID = 10;
            nihad.Name = "Nihad";
            nihad.Surname = "Shahaliyev";
            nihad.DateOfBirth = DateTime.Now.AddYears(-18);
            nihad.Parent = resad;

            var agil = new Person();
            agil.ID = 11;
            agil.Name = "Agil";
            agil.Surname = "Shahaliyev";
            agil.DateOfBirth = DateTime.Now.AddYears(-59);
            agil.Parent = ahmed;

            var rovsen = new Person();
            rovsen.ID = 12;
            rovsen.Name = "Rovsen";
            rovsen.Surname = "Shahaliyev";
            rovsen.DateOfBirth = DateTime.Now.AddYears(-58);
            rovsen.Parent = ahmed;

            var akif = new Person();
            akif.ID = 13;
            akif.Name = "Akif";
            akif.Surname = "Shahaliyev";
            akif.DateOfBirth = DateTime.Now.AddYears(-39);
            akif.Parent = agil;

            var emin = new Person();
            emin.ID = 14;
            emin.Name = "Emin";
            emin.Surname = "Shahaliyev";
            emin.DateOfBirth = DateTime.Now.AddYears(-38);
            emin.Parent = rovsen;

            var elvin = new Person();
            elvin.ID = 15;
            elvin.Name = "Elvin";
            elvin.Surname = "Shahaliyev";
            elvin.DateOfBirth = DateTime.Now.AddYears(-37);
            elvin.Parent = rovsen;

            var azad = new Person();
            azad.ID = 16;
            azad.Name = "Azad";
            azad.Surname = "Shahaliyev";
            azad.DateOfBirth = DateTime.Now.AddYears(-17);
            azad.Parent = emin;

            var malik = new Person();
            malik.ID = 17;
            malik.Name = "Malik";
            malik.Surname = "Shahaliyev";
            malik.DateOfBirth = DateTime.Now.AddYears(-16);
            malik.Parent = elvin;

            ali.Children = new System.Collections.Generic.List<Person>() { abbas, ahmed };

            abbas.Children = new System.Collections.Generic.List<Person>() { mamed, mustafa };

            mamed.Children = new System.Collections.Generic.List<Person>() { arif, resad };

            arif.Children = new System.Collections.Generic.List<Person>() { rauf };

            resad.Children = new System.Collections.Generic.List<Person> { nihad };

            mustafa.Children = new System.Collections.Generic.List<Person>() { revan };

            ahmed.Children = new System.Collections.Generic.List<Person>() { agil, rovsen };

            agil.Children = new System.Collections.Generic.List<Person>() { akif };

            rovsen.Children = new System.Collections.Generic.List<Person>() { emin, elvin };

            emin.Children = new System.Collections.Generic.List<Person>() { azad };

            elvin.Children = new System.Collections.Generic.List<Person>() { malik };

            List<Person> Persons = new List<Person>();
            Persons.Add(ali);
            Persons.Add(abbas);
            Persons.Add(mamed);
            Persons.Add(arif);
            Persons.Add(resad);
            Persons.Add(mustafa);
            Persons.Add(ahmed);
            Persons.Add(agil);
            Persons.Add(rovsen);
            Persons.Add(emin);
            Persons.Add(elvin);
            Persons.Add(azad);
            Persons.Add(malik);
            Persons.Add(akif);
            Persons.Add(nihad);
            Persons.Add(rauf);
            Persons.Add(resad);

            Console.WriteLine("Enter the ID to find the person's grandfather and 4th generous!");

            int number = int.Parse(Console.ReadLine());

            foreach (Person person in Persons)
            {
                if (number == person.ID)
                {
                    if (person.Parent != null && person.Parent.Parent !=null)
                    {
                        Console.WriteLine($"Person:{person.Name}\nGrandParent:{person.Parent.Parent.Name}");
                    }
                    else
                    {
                        Console.WriteLine("This person does not have a grandfather");
                    }
                    if (person.Children.Count != 0)
                    {
                        foreach (Person secondChild in person.Children)
                        {
                            if (secondChild.Children.Count != 0)
                            {
                                foreach(Person thirdChild in secondChild.Children)
                                {
                                    if (thirdChild.Children.Count != 0)
                                    {
                                        foreach (var fourthChild in thirdChild.Children)
                                        {
                                            Console.WriteLine($"The fourth generation of the person included: {fourthChild.Name}");
                                        }
                                    }
                                    
                                }

                            }
                        }   
                    }
                }

            }
        }
    }
}
