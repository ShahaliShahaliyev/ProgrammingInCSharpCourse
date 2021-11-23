using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(0);
           int fuel = int.Parse(Console.ReadLine());
            if (car.Refuel(fuel))
            {
                car.Drive();
            }
        }
    }
}
