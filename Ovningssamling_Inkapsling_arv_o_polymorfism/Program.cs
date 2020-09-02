using System;

namespace OvningssamlingInkapslingArvOchPolymorfism
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = null;

            try
            {
                person = new Person("Stefan", "Elmgren");
                Console.WriteLine(person.ToString()); // TODO ///////////////
            }
            catch (Exception)
            {
                
            }

            PersonHandler.SetAge(person, 53);
            Console.WriteLine(person.ToString()); // TODO ///////////////

            Person person2 = PersonHandler.CreatePerson(10, "Lisa", "Karlsson", 1.40, 35);
            Console.WriteLine(person2.ToString()); // TODO ///////////////
        }
    }
}
