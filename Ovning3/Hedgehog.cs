using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3
{
    class Hedgehog : Animal
    {
        public int NrOfSpikes { get; set; }

        public override void DoSound()
        {
            Ui.Print("Squeak");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Number of spikes: {NrOfSpikes.ToString()}";
        }
    }
}
