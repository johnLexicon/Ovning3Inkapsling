using System;
using System.Collections.Generic;
using System.Text;

namespace OvningssamlingInkapslingArvOchPolymorfism
{
    class Flamingo : Bird
    {
        public int LegLength { get; set; }

        public override string Stats()
        {
            return LegLength.ToString();
        }
    }
}
