﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OvningssamlingInkapslingArvOchPolymorfism
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

        public static void SetWeight(Person pers, int weight)
        {
            pers.Weight = weight;
        }

        public static Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person person = new Person(age, fname, lname, height, weight);
            return person;
        }
    }

    /*
    TODO: För att inkapsla Person-objekten ytterligare skall vi skapa klassen PersonHandler -
    en klass vars syfte är att skapa och hantera dina Person-objekt.
    I PersonHandler -klassen skapa metoden:
    public void SetAge(Person pers, int age)
    Använd den inskickade personens Age property för att sätta personens age-attribut
    via SetAge-metoden . Istället för att enbart använda en property har vi nu
    abstraherat med två lager.
     */
}
