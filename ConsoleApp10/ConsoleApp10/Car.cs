using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace ConsoleApp10
{
    public class Car : Vehicle, IEquatable<Car>
    {
        // Car field
        public string modelName;
        public string engine;
        public string carRegistration;

        public Car() { }

        public Car(string modelName, string engine, string carRegistration, string make)
        {
            this.modelName = modelName;
            this.engine = engine;
            this.carRegistration = carRegistration;
            this.make = make;
        }

        // Implementation of IEquatable<T> interface
        public bool Equals(Car car)
        {
            return (this.make, this.engine, this.carRegistration, this.modelName) ==
           (car.make, car.engine, car.carRegistration, car.modelName);
        }

        public void SpeedUp() {
            Console.WriteLine(" We are speeding up ...");
        }

        public override string ToString()
        {
            return "This car is a " + make + " with " + engine + " engine.";
        }

    }
}