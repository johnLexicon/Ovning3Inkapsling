using Ovning3;
using System;
using System.Collections.Generic;

#region questionsAnswers *****************************************************************************
/*
 13. F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i
vilken klass bör vi lägga det?
Svar: i Bird

14. F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
Svar: i Animal

9. F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
Svar:En Horse är inte en Dog trots att de båda ärver Animal

10. F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?
Svar: Animal

13. F: Förklara vad det är som händer.
Svar: Eftersom alla djur ärver av animal, som har en klass som heter Stats, så kan dessa djurklasser overrida klassen Stats med sina egna versioner av Stats 

16. Kommer du åt den metoden från Animals listan?
Svar: Nej

17. F: Varför inte?
Svar: För att den metoden inte finns i Animal eller någon klass som Animal ärver

11. F: Varför är polymorfism viktigt att behärska?
Svar:  Method Overloading gör så att man inte behöver repetera kod. 

12. F: Hur kan polymorfism förändra och förbättra kod via en bra struktur?
Svar: Method Overloading gör så att man inte behöver repetera kod. 

13. F: Vad är det för en skillnad på en Abstrakt klass och ett Interface?
Svar: Ett interface kan bara innehålla deklarationer men en abstrakt klass kan innehålla medlemmar och konstruktorer. 
      En klass kan ärva från flera interfaces men bara från en klass.
 */
#endregion

using System.Net.Cache;
using System.Runtime.CompilerServices;

namespace Ovning3
{
    class Program
    {
        private static IUI ui = new ConsoleUI();

        internal static IUI Ui { get => ui; set => ui = value; }

        static void Main(string[] args)
        {
            // TestingPerson();
            TestingAnimal();
            PrintUserErrorUeMessage(CreateUserErrorList());
    }

        #region methods ***********************************************************************
        private static void PrintUserErrorUeMessage(List<UserError> userErrors)
        {
            Ui.PrintLine();
            Ui.PrintLine("UEMessage(s)");
            
            foreach (UserError userError in userErrors)
            {
                Ui.PrintLine(userError.UEMessage());             
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

            Ui.PrintLine("Animals:");

            foreach (var animal in animals)
            {
                // Get the objectname without the "OvningssamlingInkapslingArvOchPolymorfism" before the dot
                string[] objectName = animal.GetType().ToString().Split('.');
                Ui.Print($"Type {objectName[1]}, ");
                Ui.Print($"Namn: {animal.Name}, Weight: {animal.Weight}, Age: {animal.Age}, ");
                Ui.Print("Sound: ");
                animal.DoSound();

                if (animal is IPerson)
                {
                    IPerson person = (IPerson)animal; // Cast Animal to IPerson
                    Ui.Print(", Sound 2: ");
                    person.Talk();
                }

                if (animal is Dog)
                {
                    Dog dog = (Dog)animal; // Cast Animal to Dog
                    Ui.Print($", ReturnString:  {dog.returnString()}");
                }

                Ui.PrintLine();
            }

            Ui.PrintLine();
            Ui.PrintLine("Animal stats");

            foreach (var animal in animals)
            {
                Ui.PrintLine(animal.Stats());
            }

            Ui.PrintLine();
            Ui.PrintLine("Dog stats");

            foreach (var animal in animals)
            {
                if (animal.GetType() == typeof(Dog))
                {
                    Ui.PrintLine(animal.Stats());
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
