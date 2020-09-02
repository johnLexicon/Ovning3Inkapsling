using System;
using System.Collections.Generic;
using System.Text;

namespace OvningssamlingInkapslingArvOchPolymorfism
{
    class Horse : Animal //Inherits Animal
    {
        public string maneColour { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Neigh");
        }
    }
}
