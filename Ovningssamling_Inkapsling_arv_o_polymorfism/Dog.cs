﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OvningssamlingInkapslingArvOchPolymorfism
{
    class Dog : Animal
    {
        public int Iq { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Woof");
        }
    }
}