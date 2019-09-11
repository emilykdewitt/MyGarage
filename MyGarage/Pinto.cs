using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage
{
    class Pinto : Car
    {
        public Pinto()
        {
            Color = "Red";
            GasCapacity = 8;
            PassengerOccupancy = 2;
        }

        public override void Refuel()
        {
            Console.WriteLine($"Only putting in $3 worth today.");
        }

        public override void Brake()
        {
            Console.WriteLine("Sccreeeeeeech these brakes sound like two howler monkeys fightin' over a banana");
        }
    }
    }
}
