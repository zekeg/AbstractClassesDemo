using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {

        public bool HasSidecar { get; set; }
        public override void DriveAbstract() {
            Console.WriteLine("Im ridin a motorcy");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("I'm driving virtual...only this time in a Motorcycle");
        }
    }
}
