using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    abstract class Vehicle
    {
        public int Year { get; set; } = 1;
        public string Make { get; set; } = "default make";
        public string Model { get; set; } = "default model";
        public abstract void DriveAbstract();
        public virtual void DriveVirtual() {
            Console.WriteLine("Virtual Drive Method Implementation, Inherited From Vehicle");
        }
    }
}
