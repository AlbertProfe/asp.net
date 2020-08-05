using System;
using ConsoleApp9;



namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {

            People barcelonaGroup = new People();

            Person pepe = new Person("Pepe", 20, "Blue");
            Person luis = new Person("Luis", 22, "Cyan");
            Person mike = new Person("Michael", 26, "Brown");

            barcelonaGroup.AddPerson(pepe);
            barcelonaGroup.AddPerson(luis);
            barcelonaGroup.AddPerson(mike);

            //barcelonaGroup.PrintPeople();
            //Console.ReadKey(); 

            Menu.OptionMenu(barcelonaGroup);

        }
    }
}
