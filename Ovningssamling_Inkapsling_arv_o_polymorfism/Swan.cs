using System;
using System.Collections.Generic;
using System.Text;

namespace OvningssamlingInkapslingArvOchPolymorfism
{
    class Swan : Bird
    {
        public int NeckLength { get; set; }

        public override string Stats()
        {
            return NeckLength.ToString();
        }
    }
}
