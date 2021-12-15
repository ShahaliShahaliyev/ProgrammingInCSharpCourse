using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class User
    {
        List<User> users = new List<User>();
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }

        public void UserList(User user)
        {
            users.Add(user);
        }

        public List<User> AllUsers()
        {
           return users;
        }

        public List<User> OlderTwenty()
        {
            return users.Where(users => users.Age > 20).ToList();
        }

        public List<User> TurkishAndLowerTen()
        {
            var deleted = users.Where(users => (users.Age < 10) && (users.Country == "Turkish")).ToList();

            foreach (var user in deleted)
            {
                users.Remove(user);
            }

            return users;
        }
    }
}
