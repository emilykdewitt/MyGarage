using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage
{
    class Vehicle
    {
        public int GasCapacity { get; set; }

        public string Color { get; set; }

        public int PassengerOccupancy { get; set; }

        public void Refuel()
        {
            Console.WriteLine($"You now have a full tank of {GasCapacity} gallons");
        }

        public void Drive()
        {
            Console.WriteLine("Vroom vroom!");
        }

        public void Brake()
        {
            Console.WriteLine("Your speed is now 0 miles per hour");
        }
    }
}
