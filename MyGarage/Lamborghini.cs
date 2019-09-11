using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage
{
    class Lamborghini : Car
    {
        public Lamborghini()
        {
            Color = "Red";
            GasCapacity = 8;
            PassengerOccupancy = 2;
        }

        public override void Refuel()
        {
            Console.WriteLine($"Who knows what's happening? You don't pump your own gas");
        }

        public override void Brake()
        {
            Console.WriteLine("I don't brake for shit.");
        }

        public void SelfPark()
        {
            Console.WriteLine("I just throw this baby in self-park mode and I'm huggin' the curb in no time");
        }
    }
}
