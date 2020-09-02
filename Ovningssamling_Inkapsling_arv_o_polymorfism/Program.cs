using System;

namespace OvningssamlingInkapslingArvOchPolymorfism
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Console.WriteLine(person2.ToString()); // TODO Testutskrift ///////////////

            PersonHandler.SetFirstName(person2, "Gittan");
            Console.WriteLine(person2.ToString()); // TODO Testutskrift ///////////////

            Person person3 = PersonHandler.CreatePerson(13, "Arne", "Olsson", 175, 81);
            Console.WriteLine(person3.ToString()); // TODO Testutskrift ///////////////

            PersonHandler.SetWeight(person3, 83);
            Console.WriteLine(person3.ToString()); // TODO Testutskrift ///////////////

            PersonHandler.SetLastName(person3, "Larsson");
            Console.WriteLine(person3.ToString()); // TODO Testutskrift ///////////////

            PersonHandler.SetHeight(person3, 165);
            Console.WriteLine(person3.ToString()); // TODO Testutskrift ///////////////

            PersonHandler.SetAge(person3, 14);
            Console.WriteLine(person3.ToString()); // TODO Testutskrift ///////////////
        }
    }
}
