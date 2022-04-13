using System.Collections;
using System.Collections.Generic;

namespace Lesson33_36.Data.Entitites
{
    public class Gender
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}