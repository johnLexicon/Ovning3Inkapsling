using System;
using System.Collections.Generic;
using System.Text;

namespace OvningssamlingInkapslingArvOchPolymorfism
{
    class Wolfman : Wolf, IPerson
    {
        public void Talk() 
        {
            Console.WriteLine("Howl");
        }
    }
}
