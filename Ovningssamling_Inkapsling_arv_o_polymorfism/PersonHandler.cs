using System;
using System.Collections.Generic;
using System.Text;

namespace OvnSamlingInkapslArvOPolym
{
    public static class PersonHandler
    {
        public static void SetFirstName(Person pers, string firstName)
        {
            pers.FName = firstName;
        }

        public static void SetLastName(Person pers, string lastName)
        {
            pers.LName = lastName;
        }

        public static void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public static void SetHeight(Person pers, int height)
        {
            pers.Height = height;
        }

        public static void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }

        public static Person CreatePerson(int age, string fname, string lname, int height, double weight)
        {
            Person person = new Person(age, fname, lname, height, weight);
            return person;
        }
    }
}
