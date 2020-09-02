using System;
using System.Collections.Generic;
using System.Net.Cache;

namespace OvningssamlingInkapslingArvOchPolymorfism
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Bird bird = new Bird();
            bird.Name = "Berit";
            bird.Age = 77;
            bird.Weight = 5;
            bird.WingSpan = 3;

            Console.WriteLine("Bird Stats:");
            Console.WriteLine(bird.Stats());
            Console.WriteLine();
            */

            List<Animal> animals = new List<Animal>();

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

            animals.Add(new Dog()
            {
                Iq = 34,
                Age = 9,
                Name = "Plupp",
                Weight = 19
            });

            animals.Add(new Horse()
            {
                Age = 4,
                Name = "Legolas",
                Weight = 125,
                maneColour = "Brown"
            });

            animals.Add(new Wolfman()
            {
                Age = 35,
                Name = "Ulrik",
                Weight = 75,
                EyeColour = "Blue"
            });

            foreach (var animal in animals)
            {
                // Get the objectname without the "OvningssamlingInkapslingArvOchPolymorfism" before the dot
                string[] objectName = animal.GetType().ToString().Split('.');
                Console.Write($"Type {objectName[1]}, ");
                Console.Write($"Namn: {animal.Name}, Weight: {animal.Weight}, Age: {animal.Age}, ");
                Console.Write("Sound: ");
                animal.DoSound();

                if (animal is IPerson)
                {
                    IPerson person = (IPerson)animal; // Cast Animal to IPerson
                    Console.Write(", Sound 2: ");
                    person.Talk();
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Animal stats");

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Stats());
            }

            Console.WriteLine();
            Console.WriteLine("Dog stats");

            foreach (var animal in animals)
            {
                if (animal.GetType() == typeof(Dog))
                {
                    Console.WriteLine(animal.Stats());
                }
                
            }

            List<Dog> dogs = new List<Dog>();

            dogs.Add(new Dog()
            {
                Age = 11,
                Name = "Larsa",
                Weight = 18,
                Iq = 28
            });

            dogs.Add(new Dog()
            {
                Age = 12,
                Name = "Fido",
                Weight = 19,
                Iq = 30
            });

            dogs.Add(new Dog()
            {
                Age = 4,
                Name = "Lissen",
                Weight = 29,
                Iq = 35
            });

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
