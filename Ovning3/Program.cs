using Ovning3;
using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Runtime.CompilerServices;

namespace Ovning3
{
    class Program
    {
        private static IUI ui = new ConsoleUI();

        static void Main(string[] args)
        {
            // TestingPerson();
            TestingAnimal();
            PrintUserErrorUeMessage(CreateUserErrorList());
    }

        #region methods *******************************************************************
        private static void PrintUserErrorUeMessage(List<UserError> userErrors)
        {
            ui.PrintLine();
            ui.PrintLine("UEMessage(s)");
            
            foreach (UserError userError in userErrors)
            {
                ui.PrintLine(userError.UEMessage());             
            }
        }

        private static List<UserError> CreateUserErrorList()
        {
            List<UserError> userErrors = new List<UserError>();
            TextInputError textInputError = new TextInputError();
            userErrors.Add(textInputError);
            NumericInputError numericInputError = new NumericInputError();
            userErrors.Add(numericInputError);
            DivisionByZeroerror divisionByZeroError = new DivisionByZeroerror();
            userErrors.Add(divisionByZeroError);
            ArrayInputError arrayInputError = new ArrayInputError();
            userErrors.Add(arrayInputError);
            WrongNumberArgumentError wrongNumberArgumentError = new WrongNumberArgumentError();
            userErrors.Add(wrongNumberArgumentError);

            return userErrors;
        }

        private static void TestingAnimal()
        {
            List<Animal> animals = new List<Animal>();

            animals.Add(new Pelican() 
            {
                beakVolume  = 10,
                Age         = 2,
                Name        = "Kurt",
                Weight      = 20,
                WingSpan    = 5
            });

            animals.Add(new Dog()
            {
                Iq      = 24,
                Age     = 5,
                Name    = "Pluffsan",
                Weight  = 25
            });

            animals.Add(new Dog()
            {
                Iq      = 34,
                Age     = 9,
                Name    = "Plupp",
                Weight  = 19
            });

            animals.Add(new Horse()
            {
                Age         = 4,
                Name        = "Legolas",
                Weight      = 125,
                maneColour  = "Brown"
            });

            animals.Add(new Wolfman()
            {
                Age         = 35,
                Name        = "Ulrik",
                Weight      = 75,
                EyeColour   = "Blue"
            });

            ui.PrintLine("Animals:");

            foreach (var animal in animals)
            {
                // Get the objectname without the "OvningssamlingInkapslingArvOchPolymorfism" before the dot
                string[] objectName = animal.GetType().ToString().Split('.');
                ui.Print($"Type {objectName[1]}, ");
                ui.Print($"Namn: {animal.Name}, Weight: {animal.Weight}, Age: {animal.Age}, ");
                ui.Print("Sound: ");
                animal.DoSound();

                if (animal is IPerson)
                {
                    IPerson person = (IPerson)animal; // Cast Animal to IPerson
                    ui.Print(", Sound 2: ");
                    person.Talk();
                }

                if (animal is Dog)
                {
                    Dog dog = (Dog)animal; // Cast Animal to Dog
                    ui.Print($", ReturnString:  {dog.returnString()}");
                }

                ui.PrintLine();
            }

            ui.PrintLine();
            ui.PrintLine("Animal stats");

            foreach (var animal in animals)
            {
                ui.PrintLine(animal.Stats());
            }

            ui.PrintLine();
            ui.PrintLine("Dog stats");

            foreach (var animal in animals)
            {
                if (animal.GetType() == typeof(Dog))
                {
                    ui.PrintLine(animal.Stats());
                }
            }

            List<Dog> dogs = new List<Dog>();

            dogs.Add(new Dog()
            {
                Age     = 11,
                Name    = "Larsa",
                Weight  = 18,
                Iq      = 28
            });

            dogs.Add(new Dog()
            {
                Age     = 12,
                Name    = "Fido",
                Weight  = 19,
                Iq      = 30
            });

            dogs.Add(new Dog()
            {
                Age     = 4,
                Name    = "Lissen",
                Weight  = 29,
                Iq      = 35
            });
        }


        private static void TestingPerson()
        {
            Person person = null;

            try
            {
                person = new Person("Stefan", "Elmgren");
            }
            catch (Exception) 
            { 
            }

            PersonHandler.SetAge(person, 53);
            Person person2 = PersonHandler.CreatePerson(10, "Lisa", "Karlsson", 140, 35);
            PersonHandler.SetFirstName(person2, "Gittan");
            Person person3 = PersonHandler.CreatePerson(13, "Arne", "Olsson", 175, 81);
            PersonHandler.SetWeight(person3, 83);
            PersonHandler.SetLastName(person3, "Larsson");
            PersonHandler.SetHeight(person3, 165);
            PersonHandler.SetAge(person3, 14);
        }
        #endregion
    }
}
