﻿namespace Ovning3
{
    class Horse : Animal //Inherits Animal
    {
        public string maneColour { get; set; }

        public override void DoSound()
        {
            Ui.Print("Neigh");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Colour of mane: {maneColour}";
        }
    }
}
