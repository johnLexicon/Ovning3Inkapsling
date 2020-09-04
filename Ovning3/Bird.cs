using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3
{
    public class Bird : Animal
    {
        private static IUI ui = new ConsoleUI();
        public int WingSpan { get; set; }

        public override void DoSound()
        {
            ui.Print("Tweet");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Wingspan: {WingSpan.ToString()}";
        }
    }
}
