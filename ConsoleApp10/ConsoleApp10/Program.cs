using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp10
{
    class Program
    {

        public static void PrintVehicles(List<Vehicle> carsToPrint)
        {
            
            Console.WriteLine("\n\nPrinting all cars and bikes:");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Size list: " + carsToPrint.Count);

            foreach (Vehicle vehicle in carsToPrint)
            {
                //Console.WriteLine(vehicle.make);
                Console.WriteLine(vehicle);
            }
            Console.WriteLine("\n\nPress any key to keep on ...");
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello C# Inherence!");

            // create car object
            Car lexus = new Car("UX 250H", "Hybrid", "TE4D4", "Lexus");

            // create bike object
            Bike giant = new Bike(5, "Hard Professional", "Giant");
            Bike orbea = new Bike(7, "-", "Orbea");

            // both car object and bike object ARE vehicles so they can access HONK
            lexus.Honk();
            giant.Honk();
            orbea.Honk();

            lexus.SpeedUp();

            List <Vehicle> vehicles = new List<Vehicle>();


            //pay attention to that, tag from superclass and object from subclass
            Vehicle lambo = new Car("Aventador S", "V12 TurboEngine-X", "EEE4D4", "Lamborginhi");
            
            //add lambo object car to vehicles list
            vehicles.Add(lambo);

            Vehicle mercedes = new Car();

            Console.WriteLine("\nList vehicle contains mercedes: " + vehicles.Contains(mercedes));

            //Console.WriteLine(vehicles);
            //call to static method PrintVehicles to print all vehicles: cars and bikes
            PrintVehicles(vehicles);

            vehicles.Add(orbea);
            vehicles.Add(lexus);
            vehicles.Add(giant);

            //call to static method PrintVehicles to print all vehicles: cars and bikes
            PrintVehicles(vehicles);

            //remove orbe object bike from vehicles list
            vehicles.Remove(orbea);

            //call to static method PrintVehicles to print all vehicles: cars and bikes
            PrintVehicles(vehicles);

            Console.WriteLine("Car Equals: " + lambo.Equals(mercedes));
            Console.WriteLine("Car Equals: " + mercedes.Equals(lambo));



        }
    }
}
