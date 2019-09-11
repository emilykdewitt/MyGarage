using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage
{
    class Car : Vehicle
    {
        public Car()
        {
            Color = "Green";
            GasCapacity = 12;
            PassengerOccupancy = 5;
        }

        public override void Refuel()
        {
            Console.WriteLine($"Your car contains {GasCapacity} gallons of gas");
        }

        public override void Brake()
        {
            Console.WriteLine("Screeeeeech your car just came to a halt");
        }

    }
}
