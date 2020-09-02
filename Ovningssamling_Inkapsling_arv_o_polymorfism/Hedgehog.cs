using System;
using System.Collections.Generic;
using System.Text;

namespace OvningssamlingInkapslingArvOchPolymorfism
{
    class Hedgehog : Animal
    {
        public int NrOfSpikes { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Squeak");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Number of spikes: {NrOfSpikes.ToString()}";
        }
    }
}
