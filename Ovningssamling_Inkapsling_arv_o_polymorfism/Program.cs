﻿using System;

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


            //PersonHandler personhandler = new PersonHandler();/////////////////
            //personhandler.SetAge(person, 10);///////////////////////

        }
    }
}
