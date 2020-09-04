using System.Runtime.CompilerServices;

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
