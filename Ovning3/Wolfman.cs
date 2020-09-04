using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

[assembly: InternalsVisibleTo("Ovning3.Ovning3Tests1")]
namespace Ovning3
{
    public class Wolfman : Wolf, IPerson
    {
        public void Talk() 
        {
            Ui.Print("Öööööh");
        }
    }
}
