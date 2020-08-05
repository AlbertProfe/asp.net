using ConsoleApp9;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    public class Person
    {
        // four fields:
        public string name;
        public int age;
        public string eyeColor;
        public Account account;
        //public accounts;

        // Constructor that takes two argument:
        public Person(string name, int age, string eyeColor)
        {
            this.name = name;
            this.age = age;
            this.eyeColor = eyeColor;

        }
        public Person(string name, int age, Account account)
        {
            this.name = name;
            this.age = age;
            this.account = account;
        }

        public override string ToString()
        {

            return "[Person values] name: " + name + " age: " + age + " eyeColor: " + eyeColor + "\n Account: " + account;
        }

        public void changeEyeColor(String newColor)
        {

            this.eyeColor = newColor;
            // pay for this operation
            Console.WriteLine("Has cambiado el color de tus ojos");
        }

        // methods, getters and setters:
        public void printPerson()
        {
            Console.WriteLine(this.name + " I am " + this.age + " years old");
        }

        public void becomeOlder()
        {
            this.age++;
        }

        public bool adult()
        {
            if (this.age < 18)
            {
                return false;
            }

            return true;
        }

        public int GetAge()
        {
            return this.age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public String getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setAccount(Account account)
        {
            this.account = account;
        }

        public String getEyeColor()
        {
            return this.eyeColor;
        }

        public void setEyeColor(string eyeColor)
        {
            this.eyeColor = eyeColor;
        }

    }
}
