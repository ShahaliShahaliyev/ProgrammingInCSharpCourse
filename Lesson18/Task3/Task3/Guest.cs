using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Guest
    {
        public string Name { get; set; }
    }

    public class Table
    {
        public Table()
        {
            Guests = new List<Guest>()
            {
             new Guest(){Name ="John"},
             new Guest(){Name = "Charlie"},
             new Guest() {Name = "Jill"},
             new Guest(){Name = "Martin"},
             new Guest(){Name = "Ann"},
             new Guest(){Name = "Eve"}
            };
        }

        public List<Guest> Guests { get; set;}

        public Guest this[int indexer]
        {
            get=> Guests[indexer];
            set => Guests[indexer] = value;
        }

        public Guest this[int indexer,string name]
        {
            get => Guests.Where(guest => guest.Name == name).FirstOrDefault();
            set => Guests[indexer] =value;
        }

    }
}
