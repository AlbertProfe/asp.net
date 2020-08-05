using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    public class Bike : Vehicle
    {
        // Bike field
        public int gear;
        public string suspension;

        // Bike constructor
        public Bike(int gear, string suspension, string make)
        {
            this.gear = gear;
            this.suspension = suspension;
            this.make = make;
        }

        public override string ToString() {

            return "This bike is a " + make + " with " + gear + " gears.";
        }
    }
}