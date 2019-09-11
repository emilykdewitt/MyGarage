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
            Console.WriteLine($"Your tank contains {GasCapacity} gallons of gas");
        }


    }
}
