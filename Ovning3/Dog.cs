using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3
{
    public class Dog : Animal
    {
        public int Iq { get; set; }

        public override void DoSound()
        {
            Console.Write("Woof");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, IQ: {Iq.ToString()}";
        }

        public string returnString()
        {
            return "Detta är lite text";
        }
    }
}
