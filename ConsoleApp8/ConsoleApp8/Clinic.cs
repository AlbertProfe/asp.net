using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    class Clinic
    {

        private double lowestWeightIndex;
        private string name;
        private string city;

        public Clinic (double indexLimit, string name, string city)
        {
            this.lowestWeightIndex = indexLimit;
            this.name = name;
            this.city = city;
        }

        public bool isAcceptedAsMember(Person person)
        {
            if (person.WeightIndex() < this.lowestWeightIndex)
            {
                return false;
            }

            return true;
        }

    }
}
