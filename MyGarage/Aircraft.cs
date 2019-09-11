using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage
{
    class Aircraft : Vehicle
    {
        public Aircraft()
        {
            Color = "Silver";
            GasCapacity = 500;
            PassengerOccupancy = 125;
        }

        public override void Refuel()
        {
            Console.WriteLine($"Your airplane contains {GasCapacity} gallons of gas");
        }

        public override void Brake()
        {
            Console.WriteLine("Screeeeeech you just touched down and came to a stop on the runway.");
        }
    }
}
