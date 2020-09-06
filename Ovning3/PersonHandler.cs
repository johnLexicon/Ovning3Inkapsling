using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3
{
    public static class PersonHandler
    {
        public static void SetFirstName(Person pers, string firstName)
        {
            if (pers != null)
            {
                pers.FName = firstName;
            }
            
        }

        public static void SetLastName(Person pers, string lastName)
        {
            if (pers != null)
            {
                pers.LName = lastName;
            }
        }

        public static void SetAge(Person pers, int age)
        {
            if (pers != null)
            {
                pers.Age = age;
            }
        }

        public static void SetHeight(Person pers, int height)
        {
            if (pers != null)
            {
                pers.Height = height;
            }
        }

        public static void SetWeight(Person pers, double weight)
        {
            if (pers != null)
            {
                pers.Weight = weight;
            }
        }

        public static Person CreatePerson(int age, string fname, string lname, int height, double weight)
        {
            Person person = new Person(age, fname, lname, height, weight);
            return person;
        }
    }
}
