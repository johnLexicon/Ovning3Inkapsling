using System;
using System.Collections.Generic;
using System.Text;

namespace OvningssamlingInkapslingArvOchPolymorfism
{
    class Wolf : Animal
    {
        public string EyeColour { get; set; }
        
        public override void DoSound()
        {
            Console.Write("Howl");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Eye color: {EyeColour}";
        }

    }
}
