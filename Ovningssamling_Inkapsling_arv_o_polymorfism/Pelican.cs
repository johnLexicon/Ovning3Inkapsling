﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OvningssamlingInkapslingArvOchPolymorfism
{
    class Pelican : Bird
    {
        public int beakVolume { get; set; }

        public override string Stats()
        {
            return $"{base.Stats()}, Beak volume: {beakVolume.ToString()}";
        }
    }
}
