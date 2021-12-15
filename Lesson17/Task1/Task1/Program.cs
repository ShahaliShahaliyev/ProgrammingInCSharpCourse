using System;
using System.Collections.Generic;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            User shahali = new User
            {
                Name = "Shahali",
                Surname = "Shahaliyev",
                Age = 17,
                Country = "Azerbaijan"
            };

            User azad = new User
            {
                Name = "Azad",
                Surname = "Abbasov",
                Age = 21,
                Country = "Azerbaijan"
            };

            User malik = new User
            {
                Name = "Malik",
                Surname = "Mammadli",
                Age = 8,
                Country = "Azerbaijan"
            };

            User ali = new User
            {
                Name = "Ali",
                Surname = "Aliyev",
                Age = 9,
                Country = "Turkish"
            };

            User ahmet = new User
            {
                Name = "Ahmet",
                Surname = "Ahmetli",
                Age = 11,
                Country = "Turkish"
            };

            User demir = new User
            {
                Name = "Demir",
                Surname = "Demirog",
                Age = 25,
                Country = "Turkish"
            };

            User tom = new User
            {
                Name = "Tom",
                Surname = "Alisia",
                Age = 26,
                Country = "English"
            };

            User mack = new User
            {
                Name = "Mack",
                Surname = "Cake",
                Age = 6,
                Country = "English"
            };

            user.UserList(shahali);
            user.UserList(tom);
            user.UserList(mack);
            user.UserList(ahmet);
            user.UserList(demir);
            user.UserList(ahmet);
            user.UserList(ali);
            user.UserList(malik);
            user.UserList(azad);

            Console.WriteLine("All Persons:\n");
            var all = user.AllUsers();
            var result = ListToString(all);
            Console.WriteLine(result);
            Console.WriteLine("-------");

            Console.WriteLine("Older than 20:\n");
            var twenty = user.OlderTwenty();
            var result1 = OlderThanTwenty(twenty);
            Console.WriteLine(result1);
            Console.WriteLine("-------");

            Console.WriteLine("Remove all users that belongs to Turkey and Age is lower than 10");
            var turkish = user.TurkishAndLowerTen();
            var result2 = TurkishAndLower10(turkish);
            Console.WriteLine(result2);
            Console.WriteLine("-------");

        }

        public static string ListToString(List<User> list)
        {
            string str = "";

            foreach (var item in list)
            {
                str += item.Name + " " + item.Surname +".";
            }


            return str;
        }

        public static string OlderThanTwenty(List<User> list1)
        {
            string str1 = string.Empty;
            foreach (var item in list1)
            {
                str1 += item.Name + " " + item.Surname + " " + item.Age + " " + item.Country + ".";
            }
            return str1;
        }

        public static string TurkishAndLower10(List<User> list2)
        {
            string str2 = string.Empty;

            foreach (var item in list2)
            {
                str2 += item.Name +" "+ item.Surname +" "+ item.Age +" "+ item.Country +"."; 
            }
            return str2 ;
        }
    }
}
