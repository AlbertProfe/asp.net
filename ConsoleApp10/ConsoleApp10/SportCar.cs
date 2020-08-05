using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    public class SportCar : Car
    {
        public double acceleration;
        public double topSpeed;

        public SportCar(string modelName, string engine, string carRegistration, string make, double acceleration, double topSpeed)
        {
            this.modelName = modelName;
            this.engine = engine;
            this.carRegistration = carRegistration;
            this.make = make;
            this.acceleration = acceleration;
            this.topSpeed = topSpeed;
        }

        public override string ToString()
        {
            return "This car is a Sport Car " + this.make + " with " + this.engine + " engine" + ", acceleration of " + this.acceleration + " m/s and a top speed of " + this.topSpeed + " km/h.";
        }

        public void TurboSpeedUp()
        {
            Console.WriteLine("Maximum power!!!");
        }

        public void startEngine()
        {
            Console.WriteLine("Your Sport Car " + this.make + " " + this.modelName + " is now on.");
        }


    }
}