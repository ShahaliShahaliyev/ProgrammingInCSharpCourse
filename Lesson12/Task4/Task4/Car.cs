using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Car : IVehicle
    {
        public int Fuel { get; set; }

        public Car(int fuel)
        {
            Fuel = fuel;
        }
        public void Drive()
        {

            if (Fuel>0)
            {
                Console.WriteLine(" Car is driving");
            }
            else
            {
                Console.WriteLine("The car does not move");
            }
        }

        public bool Refuel(int amount)
        {
            Fuel += amount;
            return true;
        }

    }
}
