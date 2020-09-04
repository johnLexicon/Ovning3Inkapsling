using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3
{
    class Wolfman : Wolf, IPerson
    {
        public void Talk() 
        {
            Ui.Print("Öööööh");
        }
    }
}
