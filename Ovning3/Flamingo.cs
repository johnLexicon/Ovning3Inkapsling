﻿namespace Ovning3
{
    class Flamingo : Bird
    {
        public int LegLength { get; set; }

        public override string Stats()
        {
            return $"{base.Stats()}, Leg length: {LegLength.ToString()}";
        }

        public override void DoSound()
        {
            System.Console.WriteLine("Flaming sound");
        }
    }
}
