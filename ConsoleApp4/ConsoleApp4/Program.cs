using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call the constructor that has no parameters.
            var person1 = new Person();
            Console.WriteLine(person1.Name);

            // Call the constructor that has one parameter.
            var person2 = new Person("Sarah Jones");
            Console.WriteLine(person2.Name);
            // Get the string representation of the person2 instance.
            Console.WriteLine(person2);

            bool check = person1.studyCSharp(180);


            if (check == false) {
                 Utilities.sendEmail(person1);   

            }

            var boby = new Dog ("Bobby", 12, "black");

            person1.pasearPerro(boby);
            boby.asignOwner(person1);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
