using System;
using System.Collections.Generic;
using System.Text;

namespace OvningssamlingInkapslingArvOchPolymorfism
{
    class Worm : Animal
    {
        public bool IsPoisonous { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Ssssss");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Is poisonous: {IsPoisonous.ToString()}";
        }
    }
}
