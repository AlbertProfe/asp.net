using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    public class Vehicle
    {
        // Vehicle field
        public string make;
        public Vehicle(){}

        public Vehicle(string make)
        {
            this.make = make;
        }

        // Vehicle method 
        public void Honk()
        {
            Console.WriteLine("Tuut, tuuuuuuuuuuuuut!");
        }

        public override string ToString()
        {
            return "This vehicle is a " + make ;
        }

        public string Make
        {
            get { return make; }
            set { make = value; }
        }
    }

}