using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
   public abstract class Vehicle
    {
        public int Year { get; set; } = 1992;
        public string Make { get; set; } = "Infiniti";
        public string Model { get; set; } = "i30";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive");
        }
    }
}
