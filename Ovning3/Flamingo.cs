using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3
{
    class Flamingo : Bird
    {
        public int LegLength { get; set; }

        public override string Stats()
        {
            return $"{base.Stats()}, Leg length: {LegLength.ToString()}";
        }
    }
}
