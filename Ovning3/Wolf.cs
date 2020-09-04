using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3
{
    public class Wolf : Animal
    {
        public string EyeColour { get; set; }
        
        public override void DoSound()
        {
           Ui.Print("Howl");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Eye color: {EyeColour}";
        }
    }
}
