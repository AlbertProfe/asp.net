using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    class Person
    {
        // four fields:
        private string name;
        private int age;
        private int height;
        private int weight;
        private Car car;


        // Constructor that takes one argument:
        public Person(String name)
        {
            this.name = name;
            this.age = 0;
            this.weight = 0;
            this.height = 0;
        }
        // Constructor that takes two argument:
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.weight = 0;
            this.height = 0;
        }

        // methods, getters and setters:
        public void PrintPerson()
        {
          Console.WriteLine(this.name + " I am " + this.age + " years old");
        }

        public void PrintPersonCar()
        {
            Console.WriteLine(this.name + " I am " + this.age + " years old, and I have got a: " + this.car.Make);
        }

        public void BecomeOlder()
        {
            this.age++;
            //BecomeOlder(1);
        }
        public void BecomeOlder(int years)
        {
            this.age += years;
        }

        public bool Adult()
        {
            if (this.age < 18)
            {
                return false;
            }

            return true;
        }

        public double WeightIndex()
        {
            double heightInMeters = this.height / 100.0;

            return this.weight / (heightInMeters * heightInMeters);
        }


        public int GetAge()
        {
            return this.age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public String GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetHeight(int height)
        {
            this.height = height;
        }

        public int GetHeight()
        {
            return this.height;
        }

        public int GetWeight()
        {
            return this.weight;
        }

        public void SetWeight(int weight)
        {
            this.weight = weight;
        }

        public Car GetCar()
        {
            return this.car;
        }

        public void SetCar(Car car)
        {
            this.car = car;
        }


    }
}
