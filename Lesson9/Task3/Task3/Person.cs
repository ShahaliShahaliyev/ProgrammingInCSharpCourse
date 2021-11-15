using System;

namespace Task3
{
    public class Person
    {
        protected int age;

        public void Greet()
        {
            var result = "Hello!";
            Console.WriteLine(result);

        }
        public void SetAge(int age)
        {
            this.age = age;
        }
    }
}
