using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp9
{
    public class People
    {
        public String name;
        public List<Person> peopleArray;
        public int size;

        public People()
        {

            this.name = "no-name";
            this.peopleArray = new List<Person>();
            this.size = peopleArray.Count();

        }

        public void AddPerson(Person person)
        {

            this.peopleArray.Add(person);
            this.size = peopleArray.Count();
        }

        public void PrintPeople()
        {

            Console.WriteLine("\nPeople:");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Name:" + this.name);
            Console.WriteLine("Size:" + this.size);

            foreach (Person p in this.peopleArray)
            {

                Console.WriteLine("[Person values] name: " + p.getName() + " age: " + p.GetAge() + " eyeColor: " +
                    p.getEyeColor() + "\n Account: " + p.account);

            }
        }
    }
}
