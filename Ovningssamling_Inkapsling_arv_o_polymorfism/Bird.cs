﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OvnSamlingInkapslArvOPolym
{
    class Bird : Animal
    {
        public int WingSpan { get; set; }

        public override void DoSound()
        {
            Console.Write("Tweet");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Wingspan: {WingSpan.ToString()}";
        }
    }
}
