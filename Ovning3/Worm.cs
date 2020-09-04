using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3
{
    class Worm : Animal
    {
        public bool IsPoisonous { get; set; }

        public override void DoSound()
        {
            Console.Write("Ssssss");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Is poisonous: {IsPoisonous.ToString()}";
        }
    }
}
