using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    class Car
    {
        private int year;
        private string make;
        private int speed;

        public Car()
        {
            this.year = 2012;
            this.make = "Lexus";
            this.speed = 256;
        }

        public Car(string make, int year, int speed)
        {
            this.year = year;
            this.make = make;
            this.speed = speed;
        }

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public int Year
        {
            get { return Year; }
            set { Year = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public void AccSpeed(int speedIncrement)
        {
            //Add check for speed limit ranges
            Speed += speedIncrement;
        }

        public void DecSpeed(int speedDecrement)
        {
            //Add check for speed limit ranges
            Speed -= speedDecrement;
        }
    }
}
