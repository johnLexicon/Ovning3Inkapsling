using System;
using System.Collections.Generic;
using System.Text;

namespace OvningssamlingInkapslingArvOchPolymorfism
{
    class Wolf : Animal
    {
        public string EyeColor { get; set; }
        
        public override void DoSound()
        {
            Console.WriteLine("Howl");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Eye color: {EyeColor}";
        }

    }
}
