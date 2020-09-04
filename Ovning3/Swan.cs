using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3
{
    public class Swan : Bird
    {
        public int NeckLength { get; set; }

        public override string Stats()
        {
            return $"{base.Stats()}, Neck length: {NeckLength.ToString()}";
        }
    }
}
