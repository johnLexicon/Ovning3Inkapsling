﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OvningssamlingInkapslingArvOchPolymorfism
{
    class Worm : Animal
    {
        public bool sPoisonous { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Ssssss");
        }
    }
}
