using System;
using System.Collections.Generic;
using System.Text;

namespace OvnSamlingInkapslArvOPolym
{
    class Wolfman : Wolf, IPerson
    {
        public void Talk() 
        {
            Console.Write("Öööööh");
        }
    }
}
