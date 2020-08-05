using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello to CSharp Classes and Objects!");


            Person tony = new Person ("Tony", 24);
            Person elsa = new Person("Elsa", 32);

            tony.SetHeight(180);
            tony.SetWeight(72);

            elsa.SetHeight(190);
            elsa.SetWeight(82);


            Person[] people = { tony, elsa };
            
            Console.WriteLine("Exemple foreach");
            foreach (Person person in people) {

                person.PrintPerson();
            }

            Clinic barcelonaMedicCenter = new Clinic(25, "Centre Medic Barcelona","Barcelona");

            if (barcelonaMedicCenter.isAcceptedAsMember(tony))
            {
                Console.WriteLine(tony.GetName() + " is accepted as a member");
            }
            else
            {
                Console.WriteLine(tony.GetName() + " is not accepted as a member");
            }

            Car lexus = new Car();

            elsa.SetCar(lexus);
            elsa.PrintPersonCar();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
