using System;
using System.Collections.Generic;
using System.Text;

namespace OvnSamlingInkapslArvOPolym
{
    class Dog : Animal
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
    }
}
