using System;
using System.Collections.Generic;
using System.Text;

namespace OvningssamlingInkapslingArvOchPolymorfism
{
    class Bird : Animal
    {
        public int WingSpan { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Tweet");
        }

        public override string Stats()
        {
            return WingSpan.ToString();
        }
    }
}
