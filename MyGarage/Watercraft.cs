using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage
{
    class Watercraft : Vehicle
    {
        public Watercraft()
        {
            Color = "Blue";
            GasCapacity = 25;
            PassengerOccupancy = 8;
        }

        public override void Refuel()
        {
            Console.WriteLine($"Your boat gas tank is full! It contains {GasCapacity} gallons");
        }

        public override void Brake()
        {
            Console.WriteLine($"Swwwoooooosh you're slowing down to enter a no-wake zone.");
        }
    }
}
