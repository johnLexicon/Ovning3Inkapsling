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

            /*PersonHandler.SetAge(person, 53);
            Console.WriteLine(person.ToString()); // TODO ///////////////
            */

            Person person2 = PersonHandler.CreatePerson(10, "Lisa", "Karlsson", 1.40, 35);
            Console.WriteLine(person2.ToString()); // TODO ///////////////

            PersonHandler.SetFirstName(person2, "Gittan");
            Console.WriteLine(person2.ToString()); // TODO Testutskrift ///////////////

            Person person3 = PersonHandler.CreatePerson(13, "Arne", "Olsson", 1.75, 81);
            Console.WriteLine(person3.ToString()); // TODO ///////////////

            PersonHandler.SetWeight(person3, 83);
            Console.WriteLine(person3.ToString()); // TODO Testutskrift ///////////////
        }
    }
}
