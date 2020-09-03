using System;
using System.Collections.Generic;
using System.Text;

namespace OvnSamlingInkapslArvOPolym
{
    class Hedgehog : Animal
    {
        public int NrOfSpikes { get; set; }

        public override void DoSound()
        {
            Console.Write("Squeak");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Number of spikes: {NrOfSpikes.ToString()}";
        }
    }
}
