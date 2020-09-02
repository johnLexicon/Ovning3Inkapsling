using System;
using System.Collections.Generic;

namespace OvningssamlingInkapslingArvOchPolymorfism
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals= new List<Animal>();

            animals.Add(new Pelican() 
            { 
                beakVolume = 10,
                Age = 2,
                Name = "Kurt",
                Weight = 20,
                WingSpan = 5
            });

            animals.Add(new Dog()
            {
                Iq = 24,
                Age = 5,
                Name = "Pluffsan",
                Weight = 25
            });

            animals.Add(new Horse()
            {
                Age = 4,
                Name = "Legolas",
                Weight = 125,
            });

            animals.Add(new Wolfman()
            {
                Age = 35,
                Name = "Ulrik",
                Weight = 75,
            });

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal}");
                Console.WriteLine($"Namn: {animal.Name}, Weight: {animal.Weight}, Age: {animal.Age}");
                animal.DoSound();

                if (animal is IPerson)
                {
                    IPerson person = (IPerson)animal; // Cast Animal to IPerson
                    person.Talk();
                }
            }

            /*
            Person person = null;

            try
            {
                person = new Person("Stefan", "Elmgren");
                Console.WriteLine(person.ToString()); // TODO ///////////////
            }
            catch (Exception)
            {
                
            }
            */

            /*
             * PersonHandler.SetAge(person, 53);
            Console.WriteLine(person.ToString()); // TODO ///////////////
            */

            Person person2 = PersonHandler.CreatePerson(10, "Lisa", "Karlsson", 140, 35);
            //Console.WriteLine(person2.ToString()); // TODO Testutskrift ///////////////

            PersonHandler.SetFirstName(person2, "Gittan");
            //Console.WriteLine(person2.ToString()); // TODO Testutskrift ///////////////

            Person person3 = PersonHandler.CreatePerson(13, "Arne", "Olsson", 175, 81);
            //Console.WriteLine(person3.ToString()); // TODO Testutskrift ///////////////

            PersonHandler.SetWeight(person3, 83);
            //Console.WriteLine(person3.ToString()); // TODO Testutskrift ///////////////

            PersonHandler.SetLastName(person3, "Larsson");
            //Console.WriteLine(person3.ToString()); // TODO Testutskrift ///////////////

            PersonHandler.SetHeight(person3, 165);
            //Console.WriteLine(person3.ToString()); // TODO Testutskrift ///////////////

            PersonHandler.SetAge(person3, 14);
            //Console.WriteLine(person3.ToString()); // TODO Testutskrift ///////////////
        }
    }
}
